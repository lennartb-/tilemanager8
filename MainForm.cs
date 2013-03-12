using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UtilityMethods;

[assembly: CLSCompliant(true)]

namespace TileManager {

    partial class MainForm : Form {
        private string destPath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        /// <param name="nowElevated">Whether the program restarted from an unelevated status.</param>

        public MainForm(bool nowElevated) {
            InitializeComponent();

            // Forces english exception messages.
            // Only applicable on non-english systems, however this can be changed (or deactivated) based on the devs' preference
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-us");

            DirLevelInfoLabel.Text = "0: Root directory only\r\n>=1: Levels of Subdirectories to search";

            // Need to be hidden by default, .Show() is called when needed
            HideIcons();

            DestinationPathSelector.Text = System.Environment.ExpandEnvironmentVariables(@"%AppData%\Microsoft\Windows\Start Menu\Programs\");
            DllFileSelector.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\shell32.dll");
            DllFileSelector.Text = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\shell32.dll";
            DllFileSelector.Items.Add("Select file...");

            // Reload DGV values from file if the application has been restarted with elevated rights
            if (nowElevated) {
                FormControls.LoadDGVfromCSV(FileListDataGridView);
                FormControls.FitColumns(FileListDataGridView);
            }
        }

        /// <summary>
        /// Populates the listview with items from a given folder. Only *.lnk files will be displayed.
        /// </summary>
        /// <param name="folder">The folder to read from.</param>

        private void FillListView(string folder) {
            StartMenuList.Clear();

            string[] files = Directory.GetFiles(folder, "*.lnk");
            string[] directories = Directory.GetDirectories(folder);
            ImageList iconList = new ImageList();
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            StartMenuList.SmallImageList = iconList;
            int imageCounter = 0;
            foreach (string dir in directories) {
                string dirName = new DirectoryInfo(dir).Name;
                dirName = "[" + dirName + "]";
                
                ListViewItem item = new ListViewItem(dirName, imageCounter++);
                item.Tag = dir;
                iconList.Images.Add(FilesystemIO.GetFolderIcon());
                StartMenuList.Items.Add(item);
            }
            
            foreach (string file in files) {

                string fileName = Path.GetFileNameWithoutExtension(file);
                ListViewItem item = new ListViewItem(fileName, imageCounter++);
                item.Tag = file;

                iconList.Images.Add(ShortcutInfo.GetIcon(file));

                StartMenuList.Items.Add(item);
            }
        }
        
        /// <summary>
        /// Hide specific buttons. Debug-only.
        /// </summary>

        private void HideIcons() {
            WarningLabel.Hide();
            ElevationButton.Hide();
            DoesNotExistLabel.Hide();
            ChangeIconButton.Hide();
            ChangeIconShellButton.Hide();
            ChangeIconImageButton.Hide();
            DllFileSelector.Hide();
        }

        /// <summary>
        /// Disable buttons that invoke actions requiring elevated privileges.
        /// </summary>

        private void DisableIcons() {

            ChangeIconButton.Enabled = false;
            ChangeIconShellButton.Enabled = false;
            ChangeIconImageButton.Enabled = false;
            DllFileSelector.Enabled = false;
            AddLinkButton.Enabled = false;
        }

        /// <summary>
        /// Re-enable buttons that invoke actions requiring elevated privileges.
        /// </summary>

        private void EnableIcons() {

            ChangeIconButton.Enabled = true;
            ChangeIconShellButton.Enabled = true;
            ChangeIconImageButton.Enabled = true;
            DllFileSelector.Enabled = true;
            AddLinkButton.Enabled = true;
        }

        #region Auto generated event handlers

        private void StartMenuList_SelectedIndexChanged(object sender, EventArgs e) {

            if ((StartMenuList.SelectedItems.Count == 1) && StartMenuList.SelectedItems[0].Tag.ToString().Contains(".lnk")) {
                ChangeIconButton.Show();
                ChangeIconShellButton.Show();
                ChangeIconImageButton.Show();
                DllFileSelector.Show();

                Icon tile = ShortcutInfo.GetIcon(StartMenuList.SelectedItems[0].Tag.ToString());
                FileIconBox.Image = tile.ToBitmap();
            }
            else if ((StartMenuList.SelectedItems.Count == 1) && !StartMenuList.SelectedItems[0].Tag.ToString().Contains(".lnk")) {
                FileIconBox.Image = FileIconBox.InitialImage;
            }
            else {
                ChangeIconButton.Hide();
                ChangeIconShellButton.Hide();
                ChangeIconImageButton.Hide();
                DllFileSelector.Hide();
            }
        }

        private void DestinationPathSelector_SelectedIndexChanged(object sender, EventArgs e) {
            Debug.WriteLine("Index changed!");
            destPath = Environment.ExpandEnvironmentVariables(DestinationPathSelector.Text);
            if (DestinationPathSelector.SelectedIndex != -1) {

                // No idea why I did that, commenting it out for now
                // Workaround, BeginInvoke() requires the form to be loaded
                //// IntPtr tempHandle = this.Handle;
                //// this.BeginInvoke((MethodInvoker)delegate {

                if (!Directory.Exists(destPath)) {
                    DoesNotExistLabel.Show();
                    Elevation.HideElevationShield(ElevationButton);
                    return;
                }
                else DoesNotExistLabel.Hide();

                if (Elevation.IsElevationRequired(destPath)) {
                    Elevation.ShowElevationShield(ElevationButton);
                    MakeShortcutButton.Enabled = false;
                    DisableIcons();
                }
                else {
                    Elevation.HideElevationShield(ElevationButton);
                    MakeShortcutButton.Enabled = true;
                    EnableIcons();
                }

                if (TabSelector.SelectedTab == StartmenuTab) {
                    if (Directory.Exists(destPath)) {
                        FillListView(destPath);
                    }
                }
                //// });
            }
        }

        private void TabSelector_SelectedIndexChanged(object sender, EventArgs e) {

            if (TabSelector.SelectedTab == StartmenuTab) {
                string destPath = Environment.ExpandEnvironmentVariables(DestinationPathSelector.Text);

                // TODO ugly
                try {
                    if (Directory.Exists(destPath)) {
                        FillListView(destPath);
                    }
                }
                catch (NullReferenceException) {
                    FillListView(destPath);
                }
            }
        }

        private void DirectoryDepthSelector_ValueChanged(object sender, EventArgs e) {

            if (DirectoryDepthSelector.Value > 1) {
                WarningLabel.Show();
            }

            if (DirectoryDepthSelector.Value < 2) {
                WarningLabel.Hide();
            }
        }

        private void ChangeIconButton_Click(object sender, EventArgs e) {
            if (IconSelector.ShowDialog() == DialogResult.OK) {

                ShortcutIO.SetShortcutIcon(IconSelector.FileName, StartMenuList.SelectedItems[0].Tag.ToString());
            }
        }

        private void DestinationPathSelector_TextChanged(object sender, EventArgs e) {
            Debug.WriteLine("Text changed!");
            destPath = System.Environment.ExpandEnvironmentVariables(DestinationPathSelector.Text);

            Debug.WriteLine("Target: " + destPath);
            if (!Directory.Exists(destPath)) {
                DoesNotExistLabel.Show();
                Elevation.HideElevationShield(ElevationButton);
                return;
            }
            else {
                DoesNotExistLabel.Hide();

                if (Elevation.IsElevationRequired(destPath)) {
                    Elevation.ShowElevationShield(ElevationButton);
                    MakeShortcutButton.Enabled = false;
                    DisableIcons();
                }
                else {
                    Elevation.HideElevationShield(ElevationButton);
                    MakeShortcutButton.Enabled = true;
                    EnableIcons();
                }

                if (TabSelector.SelectedTab == StartmenuTab) {
                    if (Directory.Exists(destPath)) {
                        FillListView(destPath);
                    }
                }
            }
        }

        private void AddLinkButton_Click(object sender, EventArgs e) {
            string destPath = FilesystemIO.ResolveVariables(DestinationPathSelector.Text);

            ShortcutIO.MakeURLShortcut(LinkTextbox.Text.ToString(), LinkNameTextbox.Text.ToString(), LinkIconBox.Tag.ToString(), destPath);
        }

        private void ChangeLinkIconButton_Click(object sender, EventArgs e) {
            if (LinkIconSelector.ShowDialog() == DialogResult.OK) {
                LinkIconBox.Image = Image.FromFile(LinkIconSelector.FileName);
                LinkIconBox.Tag = LinkIconSelector.FileName;
            }
        }

        private void ChangeIconShellButton_Click(object sender, EventArgs e) {
            int index = ShortcutIO.ShowShellIconDialog(this.Handle, DllFileSelector.SelectedItem.ToString());
            if (index != int.MaxValue) {

                ShortcutIO.SetShortcutIcon(StartMenuList.SelectedItems[0].Tag.ToString(), DllFileSelector.SelectedItem.ToString(), index);
                FileIconBox.Image = ShortcutInfo.GetIcon(StartMenuList.SelectedItems[0].Tag.ToString()).ToBitmap();
            }
        }

        private void ChangeIconImageButton_Click(object sender, EventArgs e) {
            if (ImageIconSelector.ShowDialog() == DialogResult.OK) {
                string convertedIconFile = Imaging.IcoFromImageFile(ImageIconSelector.FileName);

                ShortcutIO.SetShortcutIcon(convertedIconFile, StartMenuList.SelectedItems[0].Tag.ToString());
            }
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            // When the application is exiting, write the application data to the
            // user file and close it.
            FormControls.WriteDGVtoCSV(FileListDataGridView);
        }

        private void MakeShortcutButton_Click(object sender, EventArgs e) {

            string destPath = System.Environment.ExpandEnvironmentVariables(DestinationPathSelector.Text);
            FilesystemIO.DoesExist(destPath, true);

            for (int i = 0; i < FileListDataGridView.Rows.Count; i++) {

                if ((bool)FileListDataGridView.Rows[i].Cells[0].Value == true) {

                    if (FileListDataGridView.Rows[i].Cells[4].Value.Equals(string.Empty)) {

                        ShortcutIO.MakeShortcut((string)FileListDataGridView.Rows[i].Cells[2].Value,  // Filename
                                              (string)FileListDataGridView.Rows[i].Cells[3].Value,  // Working Directory
                                              destPath);                                            // Destination Path
                    }
                    else {
                        ShortcutIO.MakeShortcut((string)FileListDataGridView.Rows[i].Cells[2].Value,  // Filename
                                              (string)FileListDataGridView.Rows[i].Cells[3].Value,  // Working Directory
                                              destPath,                                             // Destination Path
                                              (string)FileListDataGridView.Rows[i].Cells[4].Value); // Description
                    }
                }
            }
        }

        private void ElevationButton_Click(object sender, EventArgs e) {
            Elevation.RequestElevation();
        }

        private void DllFileSelector_SelectedIndexChanged(object sender, EventArgs e) {
            if (DllFileSelector.SelectedItem.Equals("Select file...")) {

                if (DllIconSelector.ShowDialog() == DialogResult.OK) {
                    DllFileSelector.Items.Add(DllIconSelector.FileName);
                    int index = ShortcutIO.ShowShellIconDialog(this.Handle, DllIconSelector.FileName);

                    if (index != int.MaxValue) {
                        ShortcutIO.SetShortcutIcon(StartMenuList.SelectedItems[0].Tag.ToString(), DllIconSelector.FileName, index);
                        FileIconBox.Image = ShortcutInfo.GetIcon(StartMenuList.SelectedItems[0].Tag.ToString()).ToBitmap();
                    }
                }
            }
        }

        #endregion

        private void StartMenuList_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F2 && StartMenuList.SelectedItems.Count == 1) {
                StartMenuList.SelectedItems[0].BeginEdit();
            }
        }

        private void StartMenuList_AfterLabelEdit(object sender, LabelEditEventArgs e) {
            ShortcutIO.SetShortcutName(StartMenuList.Items[e.Item].Tag.ToString(), e.Label);
            StartMenuList.Items[e.Item].Tag = e.Label;
            FillListView(Environment.ExpandEnvironmentVariables(DestinationPathSelector.Text));
            StartMenuList.Items[e.Item].EnsureVisible();
            StartMenuList.Items[e.Item].Selected = true;
            StartMenuList.Items[e.Item].Focused = true;
        }
    }
}
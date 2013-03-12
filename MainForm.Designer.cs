using System.Windows.Forms;
namespace TileManager {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView FileListDataGridView;
        private System.Windows.Forms.Button FindFilesButton;
        private System.Windows.Forms.Button MakeShortcutButton;
        private System.Windows.Forms.TextBox TargetPathTextbox;
        private System.Windows.Forms.Label TargetPathLabel;
        private System.Windows.Forms.Label DestinationPathLabel;
        private System.Windows.Forms.NumericUpDown DirectoryDepthSelector;
        private System.Windows.Forms.Label DirectoryDepthLabel;
        private System.Windows.Forms.StatusStrip SearchStatusStrip;
        private System.ComponentModel.BackgroundWorker SearchWorker;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label DirLevelInfoLabel;
        private System.Windows.Forms.Button ElevationButton;
        private System.Windows.Forms.TabControl TabSelector;
        private System.Windows.Forms.TabPage ShortcutTab;
        private System.Windows.Forms.TabPage StartmenuTab;
        private System.Windows.Forms.Label DoesNotExistLabel;
        private System.Windows.Forms.ComboBox DestinationPathSelector;
        private System.Windows.Forms.ListView StartMenuList;
        private System.Windows.Forms.PictureBox FileIconBox;
        private System.Windows.Forms.Panel TabSidePanel;
        private System.Windows.Forms.Button ChangeIconButton;
        private System.Windows.Forms.OpenFileDialog IconSelector;
        private System.Windows.Forms.TabPage LinkTab;
        private System.Windows.Forms.TextBox LinkTextbox;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Button AddLinkButton;
        private System.Windows.Forms.TextBox LinkNameTextbox;
        private System.Windows.Forms.Label LinkNameLabel;
        private System.Windows.Forms.Panel LinkSidePanel;
        private System.Windows.Forms.Button ChangeLinkIconButton;
        private System.Windows.Forms.PictureBox LinkIconBox;
        private System.Windows.Forms.OpenFileDialog LinkIconSelector;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mkshortcut;
        private System.Windows.Forms.DataGridViewImageColumn appIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn appname;
        private System.Windows.Forms.DataGridViewTextBoxColumn appPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDescript;
        private System.Windows.Forms.Button ChangeIconShellButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FileListDataGridView = new System.Windows.Forms.DataGridView();
            this.mkshortcut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.appname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindFilesButton = new System.Windows.Forms.Button();
            this.MakeShortcutButton = new System.Windows.Forms.Button();
            this.TargetPathTextbox = new System.Windows.Forms.TextBox();
            this.TargetPathLabel = new System.Windows.Forms.Label();
            this.DestinationPathLabel = new System.Windows.Forms.Label();
            this.DirectoryDepthSelector = new System.Windows.Forms.NumericUpDown();
            this.DirectoryDepthLabel = new System.Windows.Forms.Label();
            this.SearchStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchWorker = new System.ComponentModel.BackgroundWorker();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.DirLevelInfoLabel = new System.Windows.Forms.Label();
            this.ElevationButton = new System.Windows.Forms.Button();
            this.TabSelector = new System.Windows.Forms.TabControl();
            this.ShortcutTab = new System.Windows.Forms.TabPage();
            this.StartmenuTab = new System.Windows.Forms.TabPage();
            this.TabSidePanel = new System.Windows.Forms.Panel();
            this.DllFileSelector = new System.Windows.Forms.ComboBox();
            this.ChangeIconImageButton = new System.Windows.Forms.Button();
            this.ChangeIconShellButton = new System.Windows.Forms.Button();
            this.ChangeIconButton = new System.Windows.Forms.Button();
            this.FileIconBox = new System.Windows.Forms.PictureBox();
            this.StartMenuList = new System.Windows.Forms.ListView();
            this.LinkTab = new System.Windows.Forms.TabPage();
            this.LinkSidePanel = new System.Windows.Forms.Panel();
            this.ChangeLinkIconButton = new System.Windows.Forms.Button();
            this.LinkIconBox = new System.Windows.Forms.PictureBox();
            this.LinkNameLabel = new System.Windows.Forms.Label();
            this.LinkNameTextbox = new System.Windows.Forms.TextBox();
            this.LinkTextbox = new System.Windows.Forms.TextBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.AddLinkButton = new System.Windows.Forms.Button();
            this.DoesNotExistLabel = new System.Windows.Forms.Label();
            this.DestinationPathSelector = new System.Windows.Forms.ComboBox();
            this.IconSelector = new System.Windows.Forms.OpenFileDialog();
            this.LinkIconSelector = new System.Windows.Forms.OpenFileDialog();
            this.ImageIconSelector = new System.Windows.Forms.OpenFileDialog();
            this.DllIconSelector = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FileListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryDepthSelector)).BeginInit();
            this.SearchStatusStrip.SuspendLayout();
            this.TabSelector.SuspendLayout();
            this.ShortcutTab.SuspendLayout();
            this.StartmenuTab.SuspendLayout();
            this.TabSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileIconBox)).BeginInit();
            this.LinkTab.SuspendLayout();
            this.LinkSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FileListDataGridView
            // 
            this.FileListDataGridView.AllowUserToAddRows = false;
            this.FileListDataGridView.AllowUserToDeleteRows = false;
            this.FileListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mkshortcut,
            this.appIcon,
            this.appname,
            this.appPath,
            this.appDescript});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.FileListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.FileListDataGridView.Name = "FileListDataGridView";
            this.FileListDataGridView.RowHeadersVisible = false;
            this.FileListDataGridView.Size = new System.Drawing.Size(723, 515);
            this.FileListDataGridView.TabIndex = 0;
            // 
            // mkshortcut
            // 
            this.mkshortcut.HeaderText = "Make Shortcut";
            this.mkshortcut.Name = "mkshortcut";
            this.mkshortcut.Width = 77;
            // 
            // appIcon
            // 
            this.appIcon.HeaderText = "Icon";
            this.appIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.appIcon.Name = "appIcon";
            this.appIcon.ReadOnly = true;
            this.appIcon.Width = 33;
            // 
            // appname
            // 
            this.appname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appname.HeaderText = "Application Name";
            this.appname.Name = "appname";
            this.appname.ReadOnly = true;
            this.appname.Width = 111;
            // 
            // appPath
            // 
            this.appPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appPath.HeaderText = "Application Path";
            this.appPath.Name = "appPath";
            this.appPath.ReadOnly = true;
            this.appPath.Width = 105;
            // 
            // appDescript
            // 
            this.appDescript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appDescript.HeaderText = "Application Description";
            this.appDescript.Name = "appDescript";
            this.appDescript.Width = 138;
            // 
            // FindFilesButton
            // 
            this.FindFilesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindFilesButton.Location = new System.Drawing.Point(12, 10);
            this.FindFilesButton.Name = "FindFilesButton";
            this.FindFilesButton.Size = new System.Drawing.Size(75, 23);
            this.FindFilesButton.TabIndex = 1;
            this.FindFilesButton.Text = "Find Files";
            this.FindFilesButton.UseVisualStyleBackColor = true;
            this.FindFilesButton.Click += new System.EventHandler(this.FindFilesButton_Click);
            // 
            // MakeShortcutButton
            // 
            this.MakeShortcutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeShortcutButton.Location = new System.Drawing.Point(12, 42);
            this.MakeShortcutButton.Name = "MakeShortcutButton";
            this.MakeShortcutButton.Size = new System.Drawing.Size(107, 23);
            this.MakeShortcutButton.TabIndex = 2;
            this.MakeShortcutButton.Text = "Make Shortcuts";
            this.MakeShortcutButton.UseVisualStyleBackColor = true;
            this.MakeShortcutButton.Click += new System.EventHandler(this.MakeShortcutButton_Click);
            // 
            // TargetPathTextbox
            // 
            this.TargetPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetPathTextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetPathTextbox.Location = new System.Drawing.Point(216, 12);
            this.TargetPathTextbox.Name = "TargetPathTextbox";
            this.TargetPathTextbox.Size = new System.Drawing.Size(444, 22);
            this.TargetPathTextbox.TabIndex = 3;
            this.TargetPathTextbox.Text = "D:\\";
            // 
            // TargetPathLabel
            // 
            this.TargetPathLabel.AutoSize = true;
            this.TargetPathLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetPathLabel.Location = new System.Drawing.Point(125, 15);
            this.TargetPathLabel.Name = "TargetPathLabel";
            this.TargetPathLabel.Size = new System.Drawing.Size(68, 13);
            this.TargetPathLabel.TabIndex = 4;
            this.TargetPathLabel.Text = "Target Path:";
            // 
            // DestinationPathLabel
            // 
            this.DestinationPathLabel.AutoSize = true;
            this.DestinationPathLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationPathLabel.Location = new System.Drawing.Point(125, 41);
            this.DestinationPathLabel.Name = "DestinationPathLabel";
            this.DestinationPathLabel.Size = new System.Drawing.Size(93, 13);
            this.DestinationPathLabel.TabIndex = 5;
            this.DestinationPathLabel.Text = "Destination Path";
            // 
            // DirectoryDepthSelector
            // 
            this.DirectoryDepthSelector.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryDepthSelector.Location = new System.Drawing.Point(216, 64);
            this.DirectoryDepthSelector.Name = "DirectoryDepthSelector";
            this.DirectoryDepthSelector.Size = new System.Drawing.Size(37, 22);
            this.DirectoryDepthSelector.TabIndex = 7;
            this.DirectoryDepthSelector.ValueChanged += new System.EventHandler(this.DirectoryDepthSelector_ValueChanged);
            // 
            // DirectoryDepthLabel
            // 
            this.DirectoryDepthLabel.AutoSize = true;
            this.DirectoryDepthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryDepthLabel.Location = new System.Drawing.Point(125, 66);
            this.DirectoryDepthLabel.Name = "DirectoryDepthLabel";
            this.DirectoryDepthLabel.Size = new System.Drawing.Size(88, 13);
            this.DirectoryDepthLabel.TabIndex = 8;
            this.DirectoryDepthLabel.Text = "Directory Depth";
            // 
            // SearchStatusStrip
            // 
            this.SearchStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripProgress,
            this.StatusStripLabel});
            this.SearchStatusStrip.Location = new System.Drawing.Point(0, 667);
            this.SearchStatusStrip.Name = "SearchStatusStrip";
            this.SearchStatusStrip.Size = new System.Drawing.Size(761, 22);
            this.SearchStatusStrip.TabIndex = 9;
            this.SearchStatusStrip.Text = "statusStrip1";
            // 
            // StatusStripProgress
            // 
            this.StatusStripProgress.Name = "StatusStripProgress";
            this.StatusStripProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusStripLabel.Text = "Ready";
            // 
            // SearchWorker
            // 
            this.SearchWorker.WorkerReportsProgress = true;
            this.SearchWorker.WorkerSupportsCancellation = true;
            this.SearchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FileSeacher_DoWork);
            this.SearchWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SearchWorker_ProgressChanged);
            this.SearchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FileSearcher_RunWorkerCompleted);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(213, 101);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(343, 13);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "Can take a while depending on depth and number of directories.";
            // 
            // DirLevelInfoLabel
            // 
            this.DirLevelInfoLabel.AutoSize = true;
            this.DirLevelInfoLabel.Location = new System.Drawing.Point(260, 65);
            this.DirLevelInfoLabel.Name = "DirLevelInfoLabel";
            this.DirLevelInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.DirLevelInfoLabel.TabIndex = 11;
            // 
            // ElevationButton
            // 
            this.ElevationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ElevationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevationButton.Location = new System.Drawing.Point(666, 36);
            this.ElevationButton.Name = "ElevationButton";
            this.ElevationButton.Size = new System.Drawing.Size(75, 23);
            this.ElevationButton.TabIndex = 12;
            this.ElevationButton.Text = "Elevate";
            this.ElevationButton.UseVisualStyleBackColor = true;
            this.ElevationButton.Click += new System.EventHandler(this.ElevationButton_Click);
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.Controls.Add(this.ShortcutTab);
            this.TabSelector.Controls.Add(this.StartmenuTab);
            this.TabSelector.Controls.Add(this.LinkTab);
            this.TabSelector.Location = new System.Drawing.Point(12, 117);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.SelectedIndex = 0;
            this.TabSelector.Size = new System.Drawing.Size(737, 547);
            this.TabSelector.TabIndex = 14;
            this.TabSelector.SelectedIndexChanged += new System.EventHandler(this.TabSelector_SelectedIndexChanged);
            // 
            // ShortcutTab
            // 
            this.ShortcutTab.Controls.Add(this.FileListDataGridView);
            this.ShortcutTab.Location = new System.Drawing.Point(4, 22);
            this.ShortcutTab.Name = "ShortcutTab";
            this.ShortcutTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutTab.Size = new System.Drawing.Size(729, 521);
            this.ShortcutTab.TabIndex = 0;
            this.ShortcutTab.Text = "Shortcuts";
            this.ShortcutTab.UseVisualStyleBackColor = true;
            // 
            // StartmenuTab
            // 
            this.StartmenuTab.BackColor = System.Drawing.SystemColors.Control;
            this.StartmenuTab.Controls.Add(this.TabSidePanel);
            this.StartmenuTab.Controls.Add(this.StartMenuList);
            this.StartmenuTab.Location = new System.Drawing.Point(4, 22);
            this.StartmenuTab.Name = "StartmenuTab";
            this.StartmenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartmenuTab.Size = new System.Drawing.Size(729, 521);
            this.StartmenuTab.TabIndex = 1;
            this.StartmenuTab.Text = "Start Menu";
            // 
            // TabSidePanel
            // 
            this.TabSidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.TabSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabSidePanel.Controls.Add(this.DllFileSelector);
            this.TabSidePanel.Controls.Add(this.ChangeIconImageButton);
            this.TabSidePanel.Controls.Add(this.ChangeIconShellButton);
            this.TabSidePanel.Controls.Add(this.ChangeIconButton);
            this.TabSidePanel.Controls.Add(this.FileIconBox);
            this.TabSidePanel.Location = new System.Drawing.Point(458, 3);
            this.TabSidePanel.Name = "TabSidePanel";
            this.TabSidePanel.Size = new System.Drawing.Size(267, 515);
            this.TabSidePanel.TabIndex = 2;
            // 
            // DllFileSelector
            // 
            this.DllFileSelector.FormattingEnabled = true;
            this.DllFileSelector.Location = new System.Drawing.Point(4, 341);
            this.DllFileSelector.Name = "DllFileSelector";
            this.DllFileSelector.Size = new System.Drawing.Size(256, 21);
            this.DllFileSelector.TabIndex = 5;
            this.DllFileSelector.SelectedIndexChanged += new System.EventHandler(this.DllFileSelector_SelectedIndexChanged);
            // 
            // ChangeIconImageButton
            // 
            this.ChangeIconImageButton.Location = new System.Drawing.Point(143, 265);
            this.ChangeIconImageButton.Name = "ChangeIconImageButton";
            this.ChangeIconImageButton.Size = new System.Drawing.Size(117, 23);
            this.ChangeIconImageButton.TabIndex = 4;
            this.ChangeIconImageButton.Text = "Change Icon (PNG)...";
            this.ChangeIconImageButton.UseVisualStyleBackColor = true;
            this.ChangeIconImageButton.Click += new System.EventHandler(this.ChangeIconImageButton_Click);
            // 
            // ChangeIconShellButton
            // 
            this.ChangeIconShellButton.Location = new System.Drawing.Point(4, 390);
            this.ChangeIconShellButton.Name = "ChangeIconShellButton";
            this.ChangeIconShellButton.Size = new System.Drawing.Size(117, 23);
            this.ChangeIconShellButton.TabIndex = 3;
            this.ChangeIconShellButton.Text = "Change Icon (DLL)...";
            this.ChangeIconShellButton.UseVisualStyleBackColor = true;
            this.ChangeIconShellButton.Click += new System.EventHandler(this.ChangeIconShellButton_Click);
            // 
            // ChangeIconButton
            // 
            this.ChangeIconButton.Location = new System.Drawing.Point(4, 265);
            this.ChangeIconButton.Name = "ChangeIconButton";
            this.ChangeIconButton.Size = new System.Drawing.Size(117, 23);
            this.ChangeIconButton.TabIndex = 2;
            this.ChangeIconButton.Text = "Change Icon (ICO)...";
            this.ChangeIconButton.Click += new System.EventHandler(this.ChangeIconButton_Click);
            // 
            // FileIconBox
            // 
            this.FileIconBox.InitialImage = null;
            this.FileIconBox.Location = new System.Drawing.Point(4, 3);
            this.FileIconBox.Name = "FileIconBox";
            this.FileIconBox.Size = new System.Drawing.Size(256, 256);
            this.FileIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FileIconBox.TabIndex = 1;
            this.FileIconBox.TabStop = false;
            // 
            // StartMenuList
            // 
            this.StartMenuList.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartMenuList.LabelEdit = true;
            this.StartMenuList.Location = new System.Drawing.Point(3, 3);
            this.StartMenuList.MultiSelect = false;
            this.StartMenuList.Name = "StartMenuList";
            this.StartMenuList.Size = new System.Drawing.Size(449, 515);
            this.StartMenuList.TabIndex = 0;
            this.StartMenuList.UseCompatibleStateImageBehavior = false;
            this.StartMenuList.View = System.Windows.Forms.View.List;
            this.StartMenuList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.StartMenuList_AfterLabelEdit);
            this.StartMenuList.SelectedIndexChanged += new System.EventHandler(this.StartMenuList_SelectedIndexChanged);
            this.StartMenuList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartMenuList_KeyDown);
            // 
            // LinkTab
            // 
            this.LinkTab.BackColor = System.Drawing.SystemColors.Control;
            this.LinkTab.Controls.Add(this.LinkSidePanel);
            this.LinkTab.Controls.Add(this.LinkNameLabel);
            this.LinkTab.Controls.Add(this.LinkNameTextbox);
            this.LinkTab.Controls.Add(this.LinkTextbox);
            this.LinkTab.Controls.Add(this.LinkLabel);
            this.LinkTab.Controls.Add(this.AddLinkButton);
            this.LinkTab.Location = new System.Drawing.Point(4, 22);
            this.LinkTab.Name = "LinkTab";
            this.LinkTab.Size = new System.Drawing.Size(729, 521);
            this.LinkTab.TabIndex = 2;
            this.LinkTab.Text = "Internet Link";
            // 
            // LinkSidePanel
            // 
            this.LinkSidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.LinkSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkSidePanel.Controls.Add(this.ChangeLinkIconButton);
            this.LinkSidePanel.Controls.Add(this.LinkIconBox);
            this.LinkSidePanel.Location = new System.Drawing.Point(458, 3);
            this.LinkSidePanel.Name = "LinkSidePanel";
            this.LinkSidePanel.Size = new System.Drawing.Size(216, 515);
            this.LinkSidePanel.TabIndex = 5;
            // 
            // ChangeLinkIconButton
            // 
            this.ChangeLinkIconButton.Location = new System.Drawing.Point(68, 136);
            this.ChangeLinkIconButton.Name = "ChangeLinkIconButton";
            this.ChangeLinkIconButton.Size = new System.Drawing.Size(86, 23);
            this.ChangeLinkIconButton.TabIndex = 2;
            this.ChangeLinkIconButton.Text = "Change Icon...";
            this.ChangeLinkIconButton.UseVisualStyleBackColor = true;
            this.ChangeLinkIconButton.Click += new System.EventHandler(this.ChangeLinkIconButton_Click);
            // 
            // LinkIconBox
            // 
            this.LinkIconBox.InitialImage = null;
            this.LinkIconBox.Location = new System.Drawing.Point(3, 3);
            this.LinkIconBox.Name = "LinkIconBox";
            this.LinkIconBox.Size = new System.Drawing.Size(210, 127);
            this.LinkIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LinkIconBox.TabIndex = 1;
            this.LinkIconBox.TabStop = false;
            this.LinkIconBox.Tag = "none";
            // 
            // LinkNameLabel
            // 
            this.LinkNameLabel.AutoSize = true;
            this.LinkNameLabel.Location = new System.Drawing.Point(9, 67);
            this.LinkNameLabel.Name = "LinkNameLabel";
            this.LinkNameLabel.Size = new System.Drawing.Size(38, 13);
            this.LinkNameLabel.TabIndex = 4;
            this.LinkNameLabel.Text = "Name:";
            // 
            // LinkNameTextbox
            // 
            this.LinkNameTextbox.Location = new System.Drawing.Point(53, 64);
            this.LinkNameTextbox.Name = "LinkNameTextbox";
            this.LinkNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.LinkNameTextbox.TabIndex = 3;
            // 
            // LinkTextbox
            // 
            this.LinkTextbox.Location = new System.Drawing.Point(53, 34);
            this.LinkTextbox.Name = "LinkTextbox";
            this.LinkTextbox.Size = new System.Drawing.Size(391, 20);
            this.LinkTextbox.TabIndex = 2;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(15, 37);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(32, 13);
            this.LinkLabel.TabIndex = 1;
            this.LinkLabel.Text = "URL:";
            // 
            // AddLinkButton
            // 
            this.AddLinkButton.Location = new System.Drawing.Point(18, 94);
            this.AddLinkButton.Name = "AddLinkButton";
            this.AddLinkButton.Size = new System.Drawing.Size(103, 23);
            this.AddLinkButton.TabIndex = 0;
            this.AddLinkButton.Text = "Add to Startscreen";
            this.AddLinkButton.UseVisualStyleBackColor = true;
            this.AddLinkButton.Click += new System.EventHandler(this.AddLinkButton_Click);
            // 
            // DoesNotExistLabel
            // 
            this.DoesNotExistLabel.AutoSize = true;
            this.DoesNotExistLabel.Location = new System.Drawing.Point(666, 41);
            this.DoesNotExistLabel.Name = "DoesNotExistLabel";
            this.DoesNotExistLabel.Size = new System.Drawing.Size(74, 13);
            this.DoesNotExistLabel.TabIndex = 15;
            this.DoesNotExistLabel.Text = "Does not exist";
            // 
            // DestinationPathSelector
            // 
            this.DestinationPathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationPathSelector.Items.AddRange(new object[] {
            "%AppData%\\Microsoft\\Windows\\Start Menu\\Programs\\",
            "%ProgramData%\\Microsoft\\Windows\\Start Menu\\Programs\\"});
            this.DestinationPathSelector.Location = new System.Drawing.Point(216, 38);
            this.DestinationPathSelector.Name = "DestinationPathSelector";
            this.DestinationPathSelector.Size = new System.Drawing.Size(444, 21);
            this.DestinationPathSelector.TabIndex = 16;
            this.DestinationPathSelector.SelectedIndexChanged += new System.EventHandler(this.DestinationPathSelector_SelectedIndexChanged);
            this.DestinationPathSelector.TextChanged += new System.EventHandler(this.DestinationPathSelector_TextChanged);
            // 
            // IconSelector
            // 
            this.IconSelector.FileName = "*.ico";
            this.IconSelector.Filter = "Icon Files|*.ico";
            // 
            // LinkIconSelector
            // 
            this.LinkIconSelector.FileName = "*.ico";
            this.LinkIconSelector.Filter = "Icon Files|*.ico";
            // 
            // ImageIconSelector
            // 
            this.ImageIconSelector.Filter = "PNG Image|*.png";
            // 
            // DllIconSelector
            // 
            this.DllIconSelector.FileName = "*.dll";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 689);
            this.Controls.Add(this.DestinationPathSelector);
            this.Controls.Add(this.DoesNotExistLabel);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.ElevationButton);
            this.Controls.Add(this.DirLevelInfoLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SearchStatusStrip);
            this.Controls.Add(this.DirectoryDepthLabel);
            this.Controls.Add(this.DirectoryDepthSelector);
            this.Controls.Add(this.DestinationPathLabel);
            this.Controls.Add(this.TargetPathLabel);
            this.Controls.Add(this.TargetPathTextbox);
            this.Controls.Add(this.MakeShortcutButton);
            this.Controls.Add(this.FindFilesButton);
            this.Name = "MainForm";
            this.Text = "TileManager";
            ((System.ComponentModel.ISupportInitialize)(this.FileListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryDepthSelector)).EndInit();
            this.SearchStatusStrip.ResumeLayout(false);
            this.SearchStatusStrip.PerformLayout();
            this.TabSelector.ResumeLayout(false);
            this.ShortcutTab.ResumeLayout(false);
            this.StartmenuTab.ResumeLayout(false);
            this.TabSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileIconBox)).EndInit();
            this.LinkTab.ResumeLayout(false);
            this.LinkTab.PerformLayout();
            this.LinkSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LinkIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button ChangeIconImageButton;
        private OpenFileDialog ImageIconSelector;
        private ComboBox DllFileSelector;
        private ToolStripStatusLabel StatusStripLabel;
        private OpenFileDialog DllIconSelector;
        private ToolStripProgressBar StatusStripProgress;
    }
}


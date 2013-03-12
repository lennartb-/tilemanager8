using System;
using System.ComponentModel;
using System.Diagnostics;
using UtilityMethods;

namespace TileManager {

    /// <summary>
    /// Contains all functions related to the file search component.
    /// </summary>

    partial class MainForm {
        private bool isSearchRunning = false;
        private FileFinder exeFinder;

        private void FindFilesButton_Click(object sender, EventArgs e) {

            if (!isSearchRunning) {
                exeFinder = new FileFinder("exe", (int)DirectoryDepthSelector.Value, FileListDataGridView);
                exeFinder.ParentWorker = SearchWorker;

                FileListDataGridView.Rows.Clear();
                FindFilesButton.Text = "Cancel";

                SearchWorker.RunWorkerAsync(exeFinder);
            }
            else {
                FileFinder.IsCancelled = true;
                SearchWorker.CancelAsync();
            }
        }

        private void FileSeacher_DoWork(object sender, DoWorkEventArgs e) {
            exeFinder.StartSearch(TargetPathTextbox.Text);
            e.Result = true;
        }

        private void FileSearcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            FormControls.FitColumns(FileListDataGridView);            
            Debug.WriteLine("Completed");
            StatusStripLabel.Text = "Finished";
            FindFilesButton.Text = "Find Files";
        }

        private void SearchWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {

            StatusStripProgress.Value = e.ProgressPercentage;
            if (e.ProgressPercentage < 100 && e.ProgressPercentage > 0) isSearchRunning = true;
            else isSearchRunning = false;
            if (e.UserState != null) {
                StatusStripLabel.Text = e.UserState.ToString();
            }
        }
    }
}
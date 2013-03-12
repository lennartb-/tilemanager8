using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UtilityMethods;

namespace TileManager {

    class FileFinder {        
        private static bool isCancelled = false;
        private int maxDepth = 1;
        private string fileExtension;
        DataGridView target;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFinder" /> class.
        /// </summary>
        /// <param name="fileExtension">The file extension to search for. Must only include the extension name itself, e.g. "exe" or "dll".</param>
        /// <param name="maxDepth">The folder depth to search. Minimum is 0 which includes one level of subfolders.</param>
        /// <param name="target">The DataGridView where the results are stored.</param>

        public FileFinder(string fileExtension, int maxDepth, DataGridView target) {
            this.fileExtension = fileExtension;
            this.maxDepth = maxDepth;
            this.target = target;
        }

        public static bool IsCancelled {
            get { return isCancelled; }
            set { isCancelled = value; }
        }

        public BackgroundWorker ParentWorker { get; set; }

        /// <summary>
        /// Initiates a file search in a given directory.
        /// </summary>
        /// <param name="dirs">The directory to search through.</param>

        public void StartSearch(string dirs) {
            InitializeSearch();

            IEnumerable<string> directories = Directory.EnumerateDirectories(dirs);
            IEnumerable<string> results;
            int currentDepth = 0;
            int dgwRowCounter = 0;
            int progressCounter = 0;

            foreach (string directory in directories) {
                results = SearchSubdirs(directory, currentDepth);

                foreach (string file in results) {
                    WriteToDgv(file, dgwRowCounter++);
                }

                ParentWorker.ReportProgress((int)(((float)progressCounter++ / (float)directories.Count()) * 100), directory);
                if (isCancelled) {
                    ParentWorker.ReportProgress(100);
                    return;
                }
            }

            ParentWorker.ReportProgress(100);
        }

        /// <summary>
        /// Initializes and resets search properties. Must be called everytime a search is started.
        /// </summary>

        private void InitializeSearch() {
            ParentWorker.ReportProgress(1);
            isCancelled = false;
        }

        /// <summary>
        /// Writes a line into the DGV. A counter for the row must be maintained.
        /// </summary>
        /// <param name="fileName">File name to write.</param>
        /// <param name="rowCounter">Row number.</param>

        private void WriteToDgv(string fileName, int rowCounter) {
            target.Invoke((MethodInvoker)delegate {
                target.Rows.Insert(
                    rowCounter,                  // Row index
                    false,                          // Checkbox                      
                    ShortcutInfo.GetIcon(fileName),  // Icon                    
                    Path.GetFileName(fileName),  // Filename
                    Path.GetDirectoryName(fileName),                     // Directory
                    FilesystemIO.GetFileDescription(Path.GetFileName(fileName), Path.GetDirectoryName(fileName), false)); // File Description                                            
            });
        }

        /// <summary>
        /// Does the actual search of subdirectories.
        /// </summary>
        /// <param name="currentDir">The current directory that is searched for files.</param>
        /// <param name="currentDepth">The current folder depth.</param>
        /// <returns>Success if succeeded, Canceled if the user canceled the search or Exception if something went wrong.</returns>

        // Partly based on http://stackoverflow.com/questions/3874516/how-to-limit-the-depth-of-a-recursive-sub-directory-search
        private IEnumerable<string> SearchSubdirs(string currentDir, int currentDepth) {

            IEnumerable<string> exeFiles;
            try {
                exeFiles = Directory.EnumerateFiles(currentDir, "*." + fileExtension);
            }
            catch (UnauthorizedAccessException uae) {
                Debug.WriteLine(uae.Message);
                yield break;
            }
            catch (PathTooLongException ptle) {
                Debug.WriteLine(ptle.Message);
                yield break;
            }

            foreach (string currentFile in exeFiles) {

                // Ignore unistaller *.exe file, the user most likely doesn't want to put them on the StartScreen
                if (currentFile.IndexOf("unins", 0, StringComparison.CurrentCultureIgnoreCase) == -1) {
                    yield return currentFile;
                }
            }

            if (currentDepth < maxDepth) {
                IEnumerable<string> subDirectories;
                currentDepth++;
                try {
                    subDirectories = Directory.EnumerateDirectories(currentDir);
                }
                catch (UnauthorizedAccessException uae) {
                    Debug.WriteLine(uae.Message);
                    yield break;
                }
                catch (PathTooLongException ptle) {
                    Debug.WriteLine(ptle.Message);
                    yield break;
                }

                foreach (string subDir in subDirectories) {
                    foreach (string file in SearchSubdirs(subDir, currentDepth)) {
                        yield return file;
                    }
                }
            }
        }
    }
}

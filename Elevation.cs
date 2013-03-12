using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace TileManager {
    public static class Elevation {

        private const uint BCM_SETSHIELD = 0x160C;

        /// <summary>
        /// Checks if the current user is an Administrator. If not the Application restarts in elevated mode.
        /// </summary>
        /// <returns>True if the process could be successfully elevated, false if not.</returns>     

        // From http://stackoverflow.com/questions/2282448/windows-7-and-vista-uac-programatically-requesting-elevation-in-c-sharp
        public static bool RequestElevation() {

            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool isAdministrator = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!isAdministrator) {
                if (TryRunElevated(Application.ExecutablePath, "loaddb") == true) {
                    Debug.WriteLine("Process started!");
                    Application.Exit();
                    return true;
                }
                else return false;
            }
            else return false;
        }        

        /// <summary>
        /// Checks if the current user has write access on a given directory, or requires elevation for that.
        /// </summary>
        /// <param name="pathToCheck">The directory name to check.</param>
        /// <returns>True if the current user requires elevation for the directory, false if not.</returns>

        public static bool IsElevationRequired(string pathToCheck) {
            pathToCheck = Environment.ExpandEnvironmentVariables(pathToCheck);

            string tempPath = pathToCheck + "\\" + Path.GetRandomFileName() + ".tmp";

            try {
                using (FileStream fileTest = System.IO.File.Open(tempPath, FileMode.OpenOrCreate)) {
                    fileTest.Close();
                    if (System.IO.File.Exists(tempPath)) {
                        Debug.WriteLine("Path Created: " + tempPath);
                        System.IO.File.Delete(tempPath);
                        return false;
                    }
                }
            }
            catch (UnauthorizedAccessException) {
                Debug.WriteLine("UAE");

                // Just return. The directory requires elevation and we can't do anything about it here.
                return true;
            }

            return true;
        }

        /// <summary>
        /// Displays the Windows UAC symbol shield on a button if a directory needs elevation for a write access.
        /// </summary>
        /// <param name="button">The button where the elevation symbol should be shown.</param>
        public static void ShowElevationShield(Button button) {
            Debug.WriteLine("Elevation required!");
            NativeMethods.SendMessage(new HandleRef(button, button.Handle), BCM_SETSHIELD, IntPtr.Zero, (IntPtr)1);
            button.Show();
        }

        public static void HideElevationShield(Button button) {
            button.Hide();
        }

        /// <summary>
        /// Tries to run an application with elevated privileges. May trigger UAC prompt.
        /// </summary>
        /// <param name="fileName">Full path to the application to start.</param>
        /// <param name="argument">Optional argument for fileName, defaults to an empty string ("").</param>
        /// <returns>true if the process was successfully started. False if not or the user cancelled the UAC prompt.</returns>

        // From http://stackoverflow.com/questions/2282448/windows-7-and-vista-uac-programatically-requesting-elevation-in-c-sharp
        private static bool TryRunElevated(string fileName, string argument = "") {

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;
            processInfo.Arguments = argument;
            processInfo.UseShellExecute = true;
            try {
                Process.Start(processInfo);
                return true;
            }
            catch (Win32Exception) {
                // User probably cancelled UAC prompt. Don't do anything here.
            }

            return false;
        }
    }
}

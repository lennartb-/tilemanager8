using System;
using System.Runtime.InteropServices;

namespace TileManager {
    static class NativeMethods {
        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        public static extern int PickIconDlg(IntPtr hWnd, System.Text.StringBuilder lpstrFile, int nMaxFile, ref int lpdwIconIndex);

        [DllImport("shell32.dll")]
        public static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);
    }
}

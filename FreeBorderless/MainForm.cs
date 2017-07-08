using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FreeBorderless
{
    public partial class MainForm : Form
    {
        // -- Declares a bunch of API stuff --
        // Finds a window
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Moves/resizes window
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        // Removes menu from window
        [DllImport("user32.dll")]
        static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        // Sets window attributes
        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, long dwNewLong);

        // Gets window attributes
        [DllImport("USER32.DLL")]
        public static extern long GetWindowLong(IntPtr hWnd, int nIndex);
        
        // Get menu
        [DllImport("user32.dll")]
        static extern IntPtr GetMenu(IntPtr hWnd);

        // Set menu
        [DllImport("user32.dll")]
        static extern IntPtr SetMenu(IntPtr windowHandle, IntPtr menuHandle);

        // Gets the item count of the menu
        [DllImport("user32.dll")]
        static extern int GetMenuItemCount(IntPtr hMenu);

        // Redraws menu bar
        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);

        // Returns rectangle of window
        [DllImport("user32.dll", SetLastError=true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        // Rectangle struct for 'GetWindowRect'
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public static uint MF_BYPOSITION = 0x400;
        public static uint MF_REMOVE = 0x1000;
        public static long WS_OVERLAPPED = 0x00000000L;
        public static long WS_CAPTION = 0x00C00000L;
        public static long WS_SYSMENU = 0x00010000L;
        public static long WS_MINIMIZEBOX = 0x00020000L;
        public static long WS_MAXIMIZEBOX = 0x00010000L;
        public static long WS_BORDER = 0x00800000L;
        public static long WS_DLGFRAME = 0x00400000L;
        public static long WS_SIZEBOX = 0x00040000L;

        // List of windows
        List<Window> windows = new List<Window>();
        List<Window> borderlessWindows = new List<Window>();

        public MainForm()
        {
            InitializeComponent();
            refreshListBtn_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected window
            Window wind = windows[processesListBox.SelectedIndex];

            // If this window does not exist, tell user and remove process
            if (FindWindow(null, wind.title) == IntPtr.Zero)
            {
                MessageBox.Show("That process no longer exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                processesListBox.Items.Remove(wind.title);
                windows.Remove(wind);
                return;
            }

            // Stores old size and position
            RECT rect;
            GetWindowRect(wind.handle, out rect);
            wind.originalSize.X = rect.Left;
            wind.originalSize.Y = rect.Top;
            wind.originalSize.Width = rect.Right - rect.Left + 1;
            wind.originalSize.Height = rect.Bottom - rect.Top + 1;

            // Gets menu
            IntPtr hmenu = GetMenu(wind.handle);
            wind.menu = hmenu;

            // Hides menu
            SetMenu(wind.handle, IntPtr.Zero);

            // Force a redraw
            DrawMenuBar(wind.handle);

            // Removes borders
            long style = GetWindowLong(wind.handle, -16);
            wind.oldStyle = style;
            SetWindowLong(wind.handle, -16, style & ~(WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX | WS_SIZEBOX));

            // Moves and resizes window to the top
            MoveWindow(wind.handle, 0, 0, 1366, 768, true);

            // Add these to borderless windows
            borderlessListBox.Items.Add(wind.title);
            borderlessWindows.Add(wind);

            // Remove this from normal processes
            processesListBox.Items.Remove(wind.title);
            windows.Remove(wind);
        }

        private void refreshListBtn_Click(object sender, EventArgs e)
        {
            // Remove everything from lists
            processesListBox.Items.Clear();
            windows.Clear();

            // Get all processes
            Process[] processes = Process.GetProcesses();

            // Add it all to lists
            foreach (Process pro in processes)
            {
                // If it's NOT blank
                if (pro.MainWindowTitle != "")
                {
                    // Get handle
                    IntPtr handle = pro.MainWindowHandle;

                    // If this handle does NOT already exist in the borderless windows list
                    bool exists = false;
                    foreach (Window w in borderlessWindows)
                    {
                        if (w.handle == handle)
                            exists = true;
                    }
                    if (!exists)
                    {
                        // Add this window to normal processes list
                        Window window = new Window();
                        window.title = pro.MainWindowTitle;
                        window.handle = handle;
                        windows.Add(window);
                        processesListBox.Items.Add(window.title);
                    }
                }
            }

            // Goes through all borderless windows. If it doesn't exist, remove it
            foreach (Window w in borderlessWindows)
            {
                // If this window does not exist, tell user and remove process
                if (FindWindow(null, w.title) == IntPtr.Zero)
                {
                    borderlessListBox.Items.Remove(w.title);
                    borderlessWindows.Remove(w);
                    return;
                }
            }
        }

        private void unborderlessBtn_Click(object sender, EventArgs e)
        {
            // Get the selected window
            Window wind = borderlessWindows[borderlessListBox.SelectedIndex];

            // If this window does not exist, tell user and remove process
            if (FindWindow(null, wind.title) == IntPtr.Zero)
            {
                MessageBox.Show("That process no longer exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                borderlessListBox.Items.Remove(wind.title);
                borderlessWindows.Remove(wind);
                return;
            }

            // Adds menu back in
            SetMenu(wind.handle, wind.menu);

            // Redraw
            DrawMenuBar(wind.handle);

            // Adds borders back
            SetWindowLong(wind.handle, -16, wind.oldStyle);

            // Moves and resizes window to the top
            MoveWindow(wind.handle,
                wind.originalSize.X,
                wind.originalSize.Y,
                wind.originalSize.Width,
                wind.originalSize.Height, true);

            // Add back to normal processes
            processesListBox.Items.Add(wind.title);
            windows.Add(wind);

            // Remove from borderless lists
            borderlessListBox.Items.Remove(wind.title);
            borderlessWindows.Remove(wind);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show(this);
        }
    }
}

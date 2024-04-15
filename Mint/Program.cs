using System;
using System.Threading;
using System.Windows.Forms;

namespace Mint
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here
        internal readonly static float Major = 2;
        internal readonly static float Minor = 0;

        /* END OF VERSION PROPERTIES */

        internal static string GetCurrentVersionToString()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionToString());
        }

        const string _mutexGuid = "{DEADMOON-0EFC7B9A-D7FC-437F-B4B3-0118C643FE19-MINT}";
        internal static Mutex MUTEX;
        static bool _notRunning;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MUTEX = new Mutex(true, _mutexGuid, out _notRunning))
            {
                if (_notRunning)
                {
                    Options.LoadSettings();
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Mint is already running in the background!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }
    }
}

using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

class Launcher
{
    static void Main(string[] args)
    {
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName         = Directory.GetCurrentDirectory() + "/bin/hl.exe";
        info.Arguments        = "bin/hlboot.dat";
        info.CreateNoWindow   = true;
        info.WindowStyle      = ProcessWindowStyle.Hidden;

        try
        {
            using (Process proc = Process.Start(info))
            {
                 proc.WaitForExit();
            }
        } catch (Win32Exception) {
            MessageBox.Show("Couldn't launch the application", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using System.Diagnostics;
using System.IO;

class Launcher
{
    static int Main(string[] args)
    {
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName       = Directory.GetCurrentDirectory() + "/bin/hl.exe";
        start.Arguments      = "hlboot.dat";
        start.WindowStyle    = ProcessWindowStyle.Hidden;
        start.CreateNoWindow = true;

        int exitCode         = -1;
        using (Process proc = Process.Start(start))
        {
             proc.WaitForExit();
             exitCode = proc.ExitCode;
        }
        return exitCode;
    }
}

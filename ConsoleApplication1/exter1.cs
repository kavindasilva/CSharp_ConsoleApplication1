using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

namespace ConsoleApplication1
{
    class exter1
    {
        public exter1()
        {
            Command2();
            //ExecuteCommand("python", 0);
            //ExecuteCommand("dir", 1000);
        }

        //works perfectly
        public void Command2()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C python";
            process.StartInfo = startInfo;
            
            process.Start();
            
            //System.Threading.Thread.Sleep(5000);
        }


        public int ExecuteCommand(string Command, int Timeout)
        {
            int ExitCode;
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo( "cmd.exe", " /C " + Command);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = true;
            Process = Process.Start(ProcessInfo);
            //Process.WaitForExit(Timeout);
            ExitCode = Process.ExitCode;
            Process.Close();

            Console.ReadLine();
            return ExitCode;
        }
    }
}

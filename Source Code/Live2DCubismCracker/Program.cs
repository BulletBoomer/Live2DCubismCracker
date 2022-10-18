using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Live2DCubismCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detecting Running Java...");
            Thread.Sleep(5000);
            Process[] process = Process.GetProcessesByName("java.exe");
            if(process.Length == 1)
            {
                Console.WriteLine("Detected Running Java!!!");
                foreach(Process java in process)
                {
                    java.Kill();
                }
                Console.WriteLine("Detecting Cracked RLM1221...");
                Thread.Sleep(5000);
                if (File.Exists("rlm1221.jar"))
                {
                    Console.WriteLine("rlm1221 has successfully cracked!!! Enjoy to use this program!!!");
                    File.Copy("rlm1221.jar", Environment.CurrentDirectory + "\\app\\lib\\rlm1221.jar", true);
                    Thread.Sleep(2100);
                    Environment.Exit(233);
                }
                else
                {
                    Console.WriteLine("RLM1221 is not Founded... Please Copy Cracked RLM1221 to CurrentDirectory Live2D Cubism...");
                    Thread.Sleep(5000);
                    Environment.Exit(1555);
                }
            }
            else
            {
                Console.WriteLine("Detecting Cracked RLM1221...");
                Thread.Sleep(5000);
                if (File.Exists("rlm1221.jar"))
                {
                    Console.WriteLine("rlm1221 has successfully cracked!!! Enjoy to use this program!!!");
                    File.Copy("rlm1221.jar", Environment.CurrentDirectory + "\\app\\lib\\rlm1221.jar", true);
                    Thread.Sleep(2100);
                    Environment.Exit(516);
                }
                else
                {
                    Console.WriteLine("RLM1221 is not Founded... Please Copy Cracked RLM1221 to CurrentDirectory Live2D Cubism...");
                    Thread.Sleep(5000);
                    Environment.Exit(1278);
                }

            }
        }
    }
}

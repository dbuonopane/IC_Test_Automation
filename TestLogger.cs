using System;
using System.IO;

namespace IC_Test_Automation
{
    public static class TestLogger
    {
        private static readonly string logFile = "TestLog.txt";

        public static void Log(string message)
        {
            string entry = $"{DateTime.Now:HH:mm:ss} - {message}";
            Console.WriteLine(entry);
            File.AppendAllText(logFile, entry + "\n");
        }
    }
}

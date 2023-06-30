using System;

namespace ConsoleApps
{
    public class Logger
    {
        private static readonly string logFilePath;
        private static int logCount;

        static Logger()
        {
            logFilePath = "log.txt";
            logCount = 0;
        }

        public static void LogMessage(string message)
        {
            logCount++;
        }

        public static int GetLogCount()
        {
            return logCount;
        }
    }

    class Program6
    {
        static void Main()
        {
            Logger.LogMessage("Повідомлення 1");
            Logger.LogMessage("Повідомлення 2");
            int count = Logger.GetLogCount();
            Console.WriteLine(count);  // 2

            Console.ReadLine();
        }

}
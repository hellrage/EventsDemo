using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EventsDemo
{
    public static class Logger
    {
        private static StreamWriter writer;
        private static string report;

        public static string Report
        {
            get { return report; }
            private set { report = value; }
        }
        
        static Logger()
        {
            writer = new StreamWriter("Log.txt");
            writer.AutoFlush = true;
            WriteLog(DateTime.Now.ToString() + "\n",false);
        }

        public static void WriteLog(string message,bool IncludeInReport)
        {
            writer.Write(message);
            if (IncludeInReport)
                report += message;
        }

        public static void CloseLog()
        {
            writer.Close();
            return;
        }
    }
}

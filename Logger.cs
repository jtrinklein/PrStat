using System;
using System.IO;
using System.Text;

namespace prstat
{
    public class Logger
    {
        private readonly string _logFile = "activity.log";
        public bool LogToFile { get; set; }
        private FileStream GetFile()
        {
            try
            {
                var path = Path.Join(AppContext.BaseDirectory, _logFile);
                return File.OpenWrite(path);
            }
            catch
            {
                return null;
            }
        }
        public void Log(string msg)
        {
            msg = $"{DateTime.Now}: {msg.Trim()}";
            Console.WriteLine(msg);
            if (!LogToFile)
            {
                return;
            }
            using var f = GetFile();
            f.Write(Encoding.ASCII.GetBytes(msg));
        }
    }
}

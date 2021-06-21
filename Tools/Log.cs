using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        public static Log _instance = null;
        private string _path;
        private static object _lock = new object();

        public static Log GetInstance(string path)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }            

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public async void Save(string message)
        {
            await File.AppendAllTextAsync(_path, DateTime.Now.ToString("f") + " - " + message + Environment.NewLine);
        }
    }
}

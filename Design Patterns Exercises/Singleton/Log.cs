using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Exercises.Singleton
{
    public class Log
    {
        public readonly static Log _instance = new Log();

        private string _path = "log.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        private Log()
        {

        }

        public async void Save(string message)
        {
            await File.AppendAllTextAsync(_path, DateTime.Now.ToString("f") + " - " + message + Environment.NewLine);
        }
    }
}

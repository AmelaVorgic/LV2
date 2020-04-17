using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class FileLogger
    {
        /*zadatak 4.*/
        private string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter fileWriter =
            new System.IO.StreamWriter(this.filePath, true))

            {
                fileWriter.WriteLine(message);
            }
        }
        /*zadatak 5.*/
        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter fileWriter =
            new System.IO.StreamWriter(this.filePath))

            {
                fileWriter.WriteLine(data.GetStringRepresentation());
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class ConsoleLogger : ILogger
    {
        /*zadatak 4.*/
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        /*zadatak 5.*/
        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}

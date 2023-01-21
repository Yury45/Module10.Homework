using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Models
{
    internal class Logger : ILogger
    {
        void ILogger.Info(string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("LogInfo: " + message);
            Console.ForegroundColor = defaultColor;
        }

        void ILogger.Warn(string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LogWarn: " + message);
            Console.ForegroundColor = defaultColor;
        }
    }
}

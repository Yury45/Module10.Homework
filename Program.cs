using System.Globalization;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using Module10.Models;

namespace Module10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            ICalculator<double> calculator1 = new Calculator<double>(logger);

            calculator1.Add(5.4, 7); 
            calculator1.Subtract(7.5, 0);

            ICalculator<int> calculator2 = new Calculator<int>(logger);

            calculator2.Add(5,7);
            calculator2.Subtract(7,0);
        }
    }
}
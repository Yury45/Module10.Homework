using System.Numerics;
using System.Text;

namespace Module10.Models
{
    internal class Calculator<T> : ICalculator<T> where T : IBinaryNumber<T>
    {
        private readonly string goodInfo = $"Успех вычисления! Тип данных: " + typeof(T);
        private readonly string badInfo = $"Ошибка вычисления! Тип данных: " + typeof(T);

        private ILogger Logger;

        public Calculator(ILogger logger)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Logger = logger;
        }

        void ICalculator<T>.Add(T a, T b)
        {
            try
            {
                Logger.Info($"{a} + {b}");
                Console.WriteLine(a + b);
                Logger.Info(goodInfo + "\n");
            }
            catch (Exception e)
            {
                Logger.Warn(badInfo);
                Logger.Warn(e.Message + "\n");
            }
        }

        void ICalculator<T>.Divide(T a, T b)
        {
            try
            {
                Logger.Info($"{a} - {b}");
                Console.WriteLine(a - b);
                Logger.Info(goodInfo + "\n");
            }
            catch (Exception e)
            {
                Logger.Warn(badInfo);
                Logger.Warn(e.Message + "\n");
            }
        }

        void ICalculator<T>.Multiply(T a, T b)
        {
            try
            {
                Logger.Info($"{a} * {b}");
                Console.WriteLine(a * b);
                Logger.Info(goodInfo + "\n");
            }
            catch (Exception e)
            {
                Logger.Warn(badInfo);
                Logger.Warn(e.Message + "\n");
            }
        }

        void ICalculator<T>.Subtract(T a, T b)
        {
            try
            {
                Logger.Info($"{a} / {b}");
                Console.WriteLine(a / b);
                Logger.Info(goodInfo + "\n");
            }
            catch (Exception e)
            {
                Logger.Warn(badInfo);
                Logger.Warn(e.Message + "\n");
            }
        }

    }

}
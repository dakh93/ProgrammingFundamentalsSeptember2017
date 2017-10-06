using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricesNum = int.Parse(Console.ReadLine());

            double threshold = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < pricesNum - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = Proc(lastPrice, currentPrice);
                bool isSignificantDifference = IsThereDifference(difference, threshold);

                string message = Get(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string Get(double currentPrice, double lastPrice, double difference, bool eitherTrueOrFalse)
        {
            string message = string.Empty;
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!eitherTrueOrFalse)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (eitherTrueOrFalse && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (eitherTrueOrFalse && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            return message;
        }

        private static bool IsThereDifference(double difference, double threshold)
        {
            if (Math.Abs(difference) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double lastPrice, double currentPrice)
        {
            double result = ((currentPrice - lastPrice) / lastPrice) * 100;
            return result;
        }
    }
}
    


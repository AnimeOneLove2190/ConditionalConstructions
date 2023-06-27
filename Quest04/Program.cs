using System;

namespace Quest04
{
    class Program
    {
        static void Main(string[] args)
        {
            double coeffA = double.Parse(Console.ReadLine());
            double coeffB = double.Parse(Console.ReadLine());
            double coeffC = double.Parse(Console.ReadLine());
            double disc = ((coeffB) * (coeffB)) - (4 * (coeffA * coeffC));
            if (disc > 0)
            {
                double xOne = (-coeffB + Math.Sqrt(disc)) / (2 * coeffA);
                double xTwo = (-coeffB - Math.Sqrt(disc)) / (2 * coeffA);
                string result = $"{xOne} {xTwo}";
                Console.WriteLine(result);
            }
            else if (disc == 0)
            {
                double xOnly = -(coeffB / (2 * coeffA));
                Console.WriteLine(xOnly);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}

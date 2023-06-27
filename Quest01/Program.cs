using System;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberMin = 0;
            if (numberOne < numberTwo)
            {
                numberMin = numberOne;
            }
            else
            {
                numberMin = numberTwo;
            }
            Console.WriteLine(numberMin);
        }
    }
}

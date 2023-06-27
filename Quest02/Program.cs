using System;

namespace Quest02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine(numberOne);
                }
            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
    }
}

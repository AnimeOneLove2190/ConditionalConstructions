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
            double interNumOne = numberOne;
            if (numberTwo > interNumOne)
            {
                interNumOne = numberTwo;
            }
            else if (numberThree > interNumOne)
            {
                interNumOne = numberThree;
            }
            Console.WriteLine(interNumOne);
        }
    }
}

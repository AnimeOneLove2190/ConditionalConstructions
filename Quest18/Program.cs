using System;

namespace Quest18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            if (numOne > numTwo)
            {
                int numIn = numTwo;
                numTwo = numOne;
                numOne = numIn;
            }
            if (numTwo > numThree)
            {
                int numInter = numThree;
                numThree = numTwo;
                numTwo = numInter;
            }
            if (numOne > numTwo)
            {
                int numInter = numTwo;
                numTwo = numOne;
                numOne = numInter;
            }
            Console.WriteLine($"{numOne} {numTwo} {numThree}");
        }
    }
}

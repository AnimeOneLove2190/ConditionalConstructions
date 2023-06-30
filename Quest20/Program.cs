using System;

namespace Quest20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            if (numOne > numTwo)
            {
                int numInter = numTwo;
                numTwo = numOne;
                numOne = numInter;
            }
            if (numTwo > numThree)
            {
                int numInter = numThree;
                numThree = numTwo;
                numTwo = numInter;
            }
            if (numThree > numFour)
            {
                int numInter = numFour;
                numFour = numThree;
                numThree = numInter;
            }
            if (numOne > numTwo)
            {
                int numInter = numTwo;
                numTwo = numOne;
                numOne = numInter;
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
            Console.WriteLine($"{numOne} {numTwo} {numThree} {numFour}");
        }
    }
}

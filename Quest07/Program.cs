using System;

namespace Quest07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            bool condOne = numberOne >= 100000;
            bool condTwo = numberOne < 1000000;
            bool condResultOne = condOne && condTwo;
            if (condResultOne == true)
            {
                int inNumOne = numberOne / 100000;
                int inNumTwo = numberOne / 10000 % 10;
                int inNumThree = numberOne / 1000 % 10;
                int inNumFour = numberOne / 100 % 10;
                int inNumFive = numberOne / 10 % 10;
                int inNumSix = numberOne % 10;
                int ResultOne = inNumOne + inNumTwo + inNumThree;
                int ResultTwo = inNumFour + inNumFive + inNumSix;
                bool finalResult = ResultOne == ResultTwo;
                Console.WriteLine(finalResult);
            }
            else
            {
                Console.WriteLine("Число не шестизначное");
            }
        }
    }
}

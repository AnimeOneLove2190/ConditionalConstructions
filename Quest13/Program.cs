using System;

namespace Quest13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            if (numTwo < numThree)
            {
                bool condOne = numOne > numTwo;
                bool condTwo = numOne < numThree;
                bool resultOne = condOne && condTwo;
                Console.WriteLine(resultOne);
            }
            else
            {
                bool condThree = numOne < numTwo;
                bool condFour = numOne > numThree;
                bool resultTwo = condThree && condFour;
                Console.WriteLine(resultTwo);
            }
        }
    }
}

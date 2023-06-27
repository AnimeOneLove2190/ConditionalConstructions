using System;

namespace Quest06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            bool condOne = numberOne >= 1000;
            bool condTwo = numberOne < 10000;
            bool interResultOne = condOne && condTwo;
            if (interResultOne == true)
            {
                int interNumberOne = numberOne / 1000;
                int interNumberTwo = numberOne / 100 % 10;
                int interNumberThree = numberOne / 10 % 10;
                int interNumberFour = numberOne % 10;
                string interResultTwo = $"{interNumberFour}{interNumberThree}{interNumberTwo}{interNumberOne}";
                int finalResult = int.Parse(interResultTwo);
                Console.WriteLine(finalResult);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

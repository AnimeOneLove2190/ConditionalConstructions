using System;

namespace Quest5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            bool condOne = (numberOne >= 10);
            bool condTwo = (numberOne < 100);
            bool resultOne = (condOne && condTwo);
            if (resultOne == true)
            {
                int interOne = numberOne / 10;
                int interTwo = numberOne % 10;
                string interThree = $"{interTwo}{interOne}";
                int resultTwo = int.Parse(interThree);
                Console.WriteLine(resultTwo);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        }
    }
}

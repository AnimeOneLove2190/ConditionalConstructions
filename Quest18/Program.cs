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
            int sortNumOne = numOne;
            int sortNumTwo = numTwo;
            int sortNumThree = numThree;
            bool minCondResOne = (numOne <= numTwo) & (numOne <= numThree);
            bool minCondResTwo = (numTwo <= numOne) & (numTwo <= numThree);
            bool minCondResThree = (numThree <= numOne) & (numThree <= numTwo);
            if (minCondResOne)
            {
                sortNumOne = numOne;
            }
            if (minCondResTwo)
            {
                sortNumOne = numTwo;
            }
            if (minCondResThree)
            {
                sortNumOne = numThree;
            }
            bool maxCondResOne = (numOne >= numTwo) & (numOne >= numThree);
            bool maxCondResTwo = (numTwo >= numOne) & (numTwo >= numThree);
            bool maxCondResThree = (numThree >= numOne) & (numThree >= numTwo);
            if (maxCondResOne)
            {
                sortNumThree = numOne;
            }
            if (maxCondResTwo)
            {
                sortNumThree = numTwo;
            }
            if (maxCondResThree)
            {
                sortNumThree = numThree;
            }
            bool mdCondOne = (numOne < sortNumThree) & (numOne > sortNumOne);
            bool mdCondTwo = (numTwo < sortNumThree) & (numTwo > sortNumOne);
            bool mdCondThree = (numThree < sortNumThree) & (numThree > sortNumOne);
            if (mdCondOne)
            {
                sortNumTwo = numOne;
            }
            if (mdCondTwo)
            {
                sortNumTwo = numTwo;
            }
            if (mdCondThree)
            {
                sortNumTwo = numThree;
            }
            string result = $"{sortNumOne} {sortNumTwo} {sortNumThree}";
            Console.WriteLine(result);
        }
    }
}

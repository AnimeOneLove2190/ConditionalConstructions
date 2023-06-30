using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            // Здесь покоится древнее зло, сортиующее три числа по убыванию...
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int sortNumOne = 0;
            int sortNumTwo = 0;
            int sortNumThree = 0;
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
            if (sortNumTwo == 0)
            {
                bool condOne = (numOne == sortNumOne) & (numTwo == sortNumOne);
                bool condTwo = (numOne == sortNumOne) & (numThree == sortNumOne);
                bool condThree = (numTwo == sortNumOne) & (numThree == sortNumOne);
                bool condFour = (numOne == sortNumThree) & (numTwo == sortNumThree);
                bool condFive = (numOne == sortNumThree) & (numThree == sortNumThree);
                bool condSix = (numTwo == sortNumThree) & (numThree == sortNumThree);
                if (condOne)
                {
                    sortNumTwo = sortNumOne;
                }
                if (condTwo)
                {
                    sortNumTwo = sortNumOne;
                }
                if (condThree)
                {
                    sortNumTwo = sortNumOne;
                }
                if (condFour)
                {
                    sortNumTwo = sortNumThree;
                }
                if (condFive)
                {
                    sortNumTwo = sortNumThree;
                }
                if (condSix)
                {
                    sortNumTwo = sortNumThree;
                }
            }
            string result = $"{sortNumOne} {sortNumTwo} {sortNumThree}";
            Console.WriteLine(result);
        }
    }
}

using System;

namespace Quest03
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordinateOneOne = int.Parse(Console.ReadLine());
            int coordinateOneTwo = int.Parse(Console.ReadLine());
            int coordinateTwoone = int.Parse(Console.ReadLine());
            int coordinateTwoTwo = int.Parse(Console.ReadLine());
            bool conditionOne = (coordinateTwoone > coordinateOneOne);
            bool conditionTwo = (coordinateTwoone > coordinateOneTwo);
            bool conditionThree = (coordinateTwoTwo > coordinateOneOne);
            bool conditionFour = (coordinateTwoTwo > coordinateOneTwo);
            bool conditionFive = (coordinateTwoone < coordinateOneOne);
            bool conditionSix = (coordinateTwoone < coordinateOneTwo);
            bool conditionSeven = (coordinateTwoTwo < coordinateOneOne);
            bool conditionEight = (coordinateTwoTwo < coordinateOneTwo);
            bool resultOne = (conditionOne && conditionTwo && conditionThree && conditionFour);
            bool resultTwo = (conditionFive && conditionSix && conditionSeven && conditionEight);
            bool ebaniyRot = !(resultOne || resultTwo);
            Console.WriteLine(ebaniyRot);
        }
    }
}

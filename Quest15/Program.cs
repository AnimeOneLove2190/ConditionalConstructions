using System;

namespace Quest15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            string signOne = Console.ReadLine();
            const string PLUS = "+";
            const string MINUS = "-";
            const string MULTIPL = "*";
            const string DIVISION = "/";
            switch (signOne)
            {
                case PLUS:
                    int resultPlus = numOne + numTwo;
                    Console.WriteLine(resultPlus);
                    break;
                case MINUS:
                    int resultMinus = numOne - numTwo;
                    Console.WriteLine(resultMinus);
                    break;
                case MULTIPL:
                    int resultMultipl = numOne * numTwo;
                    Console.WriteLine(resultMultipl);
                    break;
                case DIVISION:
                    int resultDivision = numOne / numTwo;
                    Console.WriteLine(resultDivision);
                    break;
                default:
                        Console.WriteLine("Похоже, вы ввели неправильные данные");
                    break;
            }
        }
    }
}

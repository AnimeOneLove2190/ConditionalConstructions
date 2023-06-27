using System;

namespace Quest10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int inNumOne = numOne / 10;
            int inNumTwo = numOne % 10;
            bool resultOne = inNumOne >= inNumTwo;
            bool resultTwo = inNumOne <= inNumTwo;
            if (resultOne == true)
            {
                Console.WriteLine(inNumOne);
            }
            else
            {
                Console.WriteLine(inNumTwo);
            }
        }
    }
}

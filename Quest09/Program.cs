using System;

namespace Quest09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            numOne = numOne % 2;
            bool nya = numOne == 0;
            Console.WriteLine(nya);
        }
    }
}

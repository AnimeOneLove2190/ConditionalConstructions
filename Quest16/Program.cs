using System;

namespace Quest16
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }
        }
    }
}

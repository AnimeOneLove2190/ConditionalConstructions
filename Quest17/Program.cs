using System;

namespace Quest17
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradeOne = int.Parse(Console.ReadLine());
            switch (gradeOne)
            {
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 1:
                    Console.WriteLine("Неудовлетворительно");
                    break;
            }
        }
    }
}

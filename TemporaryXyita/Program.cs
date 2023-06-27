using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            // проверка полов
            string floor1 = Console.ReadLine();
            bool floor2 = floor1 == "м";
            Console.WriteLine(floor2);
            Console.WriteLine("след");
            Console.ReadLine();
            // проверка формул
            double mk1 = double.Parse(Console.ReadLine());
            mk1 = (-mk1 + Math.Sqrt(mk1)) / (2 * mk1);
            Console.WriteLine(mk1);
            Console.WriteLine("след");
            Console.ReadLine();
            // конвертация (оно же привидение) стринги в инты
            string mk2 = "23";
            int mk3 = int.Parse(mk2);
            Console.WriteLine(mk3);
            Console.WriteLine("след");
            Console.ReadLine();
            // ебтвою названия файлов сука 5 квест блять
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

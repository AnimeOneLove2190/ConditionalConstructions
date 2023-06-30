using System;

namespace Quest19
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            string gradeA = "A";
            string gradeB = "B";
            string gradeC = "C";
            string gradeD = "D";
            string gradeF = "F";
            if ((score >= 90) & (score <= 100))
            {
                Console.WriteLine(gradeA);
            }
            if ((score >= 80) & (score <= 89))
            {
                Console.WriteLine(gradeB);
            }
            if ((score >= 70) & (score <= 79))
            {
                Console.WriteLine(gradeC);
            }
            if ((score >= 60) & (score <= 69))
            {
                Console.WriteLine(gradeD);
            }
            if ((score >= 0) & (score <= 59))
            {
                Console.WriteLine(gradeF);
            }
        }
    }
}

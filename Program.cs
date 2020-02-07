using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradescore;
            Console.WriteLine("Please enter your in your grade out of 100 then hit enter");
            gradescore = Convert.ToInt32(Console.ReadLine());

            if (gradescore >= 100 && gradescore >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (gradescore >= 92 && gradescore <= 97)
            {
                Console.WriteLine("A");
            }
            else if (gradescore >= 90 && gradescore <= 91)
            {
                Console.WriteLine("A-");
            }
            else if (gradescore >= 88 && gradescore <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (gradescore >= 82 && gradescore <= 87)
            {
                Console.WriteLine("B");
            }
            else if (gradescore >= 80 && gradescore <= 81)
            {
                Console.WriteLine("B-");
            }
            else if (gradescore >= 78 && gradescore <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (gradescore >= 72 && gradescore <= 77)
            {
                Console.WriteLine("C");
            }
            else if (gradescore >= 70 && gradescore <= 71)
            {
                Console.WriteLine("C-");
            }
            else if (gradescore >= 68 && gradescore <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (gradescore >= 62 && gradescore <= 67)
            {
                Console.WriteLine("D");
            }
            else if (gradescore >= 60 && gradescore <= 61)
            {
                Console.WriteLine("D-");
            }
            else if (gradescore >= 0 && gradescore <= 60)
            {
                Console.WriteLine("F");
            }
        
        }
    }
}

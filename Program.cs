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

            if (gradescore >= 100 && gradescore >= 90)
            {
                Console.WriteLine("A");
            }
            else if (gradescore >= 80 && gradescore <= 89)
            {
                Console.WriteLine("B");
            }
            else if (gradescore >= 70 && gradescore <= 79)
            {
                Console.WriteLine("C");
            }
            else if (gradescore >= 60 && gradescore <= 69)
            {
                Console.WriteLine("D");
            }
            else if (gradescore <= 59 && gradescore >= 0)
            {
                Console.WriteLine("F");
            }
        
        }
    }
}

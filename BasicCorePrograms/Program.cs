using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Welcome to QuotientReminder Program");
            Console.WriteLine("Enter divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divident");
            int Divident = Convert.ToInt32(Console.ReadLine());
            QuotientAndReminder.QuotientReminder(Divisor, Divident);
            Console.ReadLine();
        }
    }
}
               
        






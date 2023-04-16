
using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Welcome to Basic Core Programming");
            Console.WriteLine("Please enter integer number to find even or odd");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EvenorOddNumbers.FindEvenorOdd(input));
        }
    }
}        

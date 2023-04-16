// See https://aka.ms/new-console-template for morusing BasicCorePrograms;
using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Program of Prime Factorization");
            int n = Convert.ToInt32(Console.ReadLine());  
            PrimeFactorization.primeFactors(n);
            Console.ReadLine();

        }
    }
}

using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Program of flip Coin");
            FlipCoin flip = new FlipCoin();
            flip.flipCoin();
        }
    }
}
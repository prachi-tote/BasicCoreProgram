
using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1.QuotientAndReminder\n2.SwapNumbers\n3.PrimeFactorization\n4.HarmonicNumber\n5.FlipCoin\n6.EvenOdd\n7.VowelConsonent\n8.Leapyear\n9.Powerof2\n10.LargestNumber");
            LargestNumber largest = new LargestNumber();
            largest.largeNum();
        }
        
    }
}

// See https://aka.ms/new-console-template for more information
using BasicCorePrograms;
using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography;
using static BasicCorePrograms.VowelorConsonent;

namespace BasicCsharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1.QuotientAndReminder\n2.SwapNumbers\n3.PrimeFactorization\n4.HarmonicNumber\n5.FlipCoin\n8.Leapyear");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    //  QuotientAndReminder.QuotientReminder();
                    Console.WriteLine("Enter divisor");
                    int Divisor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter divident");
                    int Divident = Convert.ToInt32(Console.ReadLine());
                    QuotientAndReminder.QuotientReminder(Divisor, Divident);
                    Console.ReadLine();
                    break;

                case 2:
                    SwapNumbers.SwapNum();
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Print the prime factors of number n");
                    int n = Convert.ToInt32(Console.ReadLine());
                    PrimeFactorization.primeFactors(n);
                    Console.ReadLine();
                    break;

                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicNum();
                    break;

                case 5:
                    FlipCoin flip = new FlipCoin();
                    flip.flipCoin();
                    break;

                case 6:
                    Console.WriteLine("Please enter integer number to find even or odd");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(EvenorOddNumbers.FindEvenorOdd(input));
                    Console.ReadLine();
                    break;
                case 7:
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.alphabet();
                    break;
                case 8:
                    Leapyear leapyear = new Leapyear();
                    leapyear.Year();
                    break;

            }
        }
    }
}











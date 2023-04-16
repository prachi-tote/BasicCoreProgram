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
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Program to find Consonant or Vowel");
            VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
            vowelOrConsonant.alphabet();
        }
    }
}
 
                 









using BasicCorePrograms;
using System;

namespace BasicCsharpProgram
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Program to find Consonant or Vowel");
            VowelorConsonent consonent = new VowelorConsonent();
            consonent.alphabet();
        }
    }
}

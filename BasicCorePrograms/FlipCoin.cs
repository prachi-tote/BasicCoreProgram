using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoin 
    {
        public void flipCoin()
        {
            Console.WriteLine(" Enter a number to flip the coin for number of times");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            float heads = 0, tails = 0;
            Console.WriteLine("After fliping the coin we get");
            for (int i = 1; i <= n; i++)
            {
                int num = rnd.Next(2);
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Head");
                        heads++;
                        break;
                    case 1:
                        Console.WriteLine("Tail");
                        tails++;
                        break;
                }
            }
            float head_percentage = (heads / (tails + heads)) * 100;
            float tail_percentage = (tails / (tails + heads)) * 100;
            Console.WriteLine($"\nHead perctage = {head_percentage}%");
            Console.WriteLine($"Tail perctage = {tail_percentage}%");
        }
    }

}

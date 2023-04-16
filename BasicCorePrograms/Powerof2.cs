using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Powerof2
    {

        public void powOf2()
        {
            Console.WriteLine("Upto what number you want to print the table:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The table of powers of 2 upto " + n);
            int value = 2;

            for (int power = 0; power <= n; power++)
            {
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0}");
            }
        }
    }
}

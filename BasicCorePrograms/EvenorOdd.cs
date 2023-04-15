using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenorOddNumbers
    {
        public static string FindEvenorOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Given number is even";
            }
            else
            {
                return "Given number is odd";
            }
        }
    }
}
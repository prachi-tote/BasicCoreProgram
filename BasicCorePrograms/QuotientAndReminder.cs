using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndReminder
    {
        public static void QuotientReminder(int Divident, int Divisor)
        {
            
            int quotient = Divident / Divisor;
            int remainder = Divident % Divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}", Divident, Divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();

        }

    }
}

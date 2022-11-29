using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylearning
{
    internal class GOTO
    {
        static void Main()
        {
            int i = 1;
            Console.WriteLine("INDIA");
            Console.WriteLine("SRI LANKA");
            Console.WriteLine("CHINA");
        startLabel:
            Console.WriteLine("USA");
            Console.WriteLine("UAE");
            Console.WriteLine("CANADA");
            i++;
            if (i <= 5)
            {
                goto startLabel;
            }

            //Console.WriteLine("ITALY");
            //Console.WriteLine("UK");
            //Console.WriteLine("RUSSIA");
            //Console.WriteLine("INDIA");
            //Console.WriteLine("SA");

            //Console.WriteLine("Enter the country");
            //Console.WriteLine("Mycountry is india");
            Console.ReadLine();

        }
    }
}

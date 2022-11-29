using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylearning
{
    internal class Switch_case
    {
        static void Main()
        {
            Console.WriteLine("Enter the letter:");
            char L = Convert.ToChar(Console.ReadLine());
            string LDesc;
            switch (L)
            {
                case 'O':LDesc = "Outstanding";break;
                case 'A': LDesc = "Excellent"; break;
                case 'B': LDesc = "Good"; break;
                case 'C': LDesc = "Average"; break;
                case 'F': LDesc = "Fail"; break;
                default:LDesc = "Null";break;

            }
            Console.WriteLine(LDesc);
            Console.ReadLine();
        }
    }
}

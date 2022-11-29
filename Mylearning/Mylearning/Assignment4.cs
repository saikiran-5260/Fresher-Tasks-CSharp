using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylearning
{
    internal class Assignment4
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5 | j == 6)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 10; j >= 1; j--)
                {
                    if (i == 2)
                    {
                        if (j == 2 || j == 1)
                        {
                            continue;
                        }
                    }
                    if (i == 4)
                    {
                        if (j == 3)
                        {
                            continue;
                        }
                        Console.Write((11 - j) + " ");
                        continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



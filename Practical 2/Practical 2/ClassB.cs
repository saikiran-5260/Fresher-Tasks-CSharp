using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    public class ClassB
    {
        //public void AdamNum()
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    int revNum = Reverse(num);
        //    bool IsAdam = Math.Pow(num, 2) == Reverse((int)Math.Pow(revNum, 2));
        //    if (IsAdam == true)
        //    {
        //        Console.WriteLine("The given number is adam");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not an adam number");
        //    }
        //}
        
        //private int Reverse(int num)
        //{
        //    int result = 0;
        //    while (num > 0)
        //    {
        //        result = result * 10 + num % 10;
        //        num /= 10;
        //    }
        //    return result;
        //}

        //public void Factorial()
        //{
        //    int fact = 1;
        //    int number = int.Parse(Console.ReadLine());
        //    for(int i = 1; i <= number; i++)
        //    {
        //        fact *= i;
        //    }
        //    Console.WriteLine("The factorial of given number{0} is {1}",number,fact);
        //}
        //public void Fibonacci()
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    int n1 = 0, n2 = 1, n3;
        //    Console.Write(n1+","+n2+",");
        //    for(int i = 2; i <= number; i++)
        //    {
        //        n3 = n1 + n2;
        //        Console.Write(n3+",");
        //        n1 = n2;
        //        n2 = n3;
        //    }
        //}
        public void StringReverse()
        {
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine("Reverse of string: "+chars);
            string s = new string(chars);
            Console.WriteLine(s);


        }
    }
}

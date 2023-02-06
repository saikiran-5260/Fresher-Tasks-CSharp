using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practical1
{
    public class ClassA
    {
        

        public void PrimeNumber()
        {
            int num;
            int count = 0;
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("The given number is prime");
            }
            else
            {
                Console.WriteLine("The given number is not prime");
            }
        }
        public void AmstrongNumber()
        {
            int n, temp; double c=0, r, sum = 0;
            Console.Write("Enter the Number: ");
            int num= int.Parse(Console.ReadLine());
            temp = num;n = num;
            while (n != 0)
            {
                int te = n % 10;
                c = c + 1;
                n = n / 10;
            }
            while (num > 0)
            {
                r = num % 10;
                sum = sum + Math.Pow(r,c);
                num = num / 10;
            }
            if (temp == sum)
                Console.Write("The given number is Armstrong Number.");
            else
                Console.Write("The given number is not Armstrong Number.");
        }
        public void Palindrome()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
        public void Factorial()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
        public void AdamNumber()
        {
            int num = 12;
            int revNum = Reverse(num);
            bool isAdamNum = Math.Pow(num, 2) == Reverse((int)Math.Pow(revNum, 2));
            if (isAdamNum == true)
            {
                Console.WriteLine("The given number is adam number");
            }
            else
            {
                Console.WriteLine("Not an adam Number");
            }
        }

        private int Reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
        public void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        public void FibonacciSeriesOfNthNum()
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            //Console.Write(n1+"\t"+n2+"\t");
            ArrayList al = new ArrayList();
            al.Add(n1);
            al.Add(n2);
            for (int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                //Console.Write(n3+"\t");
                al.Add(n3);
                n1 = n2;
                n2 = n3;
            }
            foreach (int item in al)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("");
            Console.Write("Enter the nth number of the series: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The nth number of the series is: " + al[n]);
        }
    }
}

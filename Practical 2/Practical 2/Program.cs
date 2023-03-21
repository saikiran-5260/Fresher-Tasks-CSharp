

////Prime Number
//int count = 0;
//int num =int.Parse(Console.ReadLine());
//for(int i = 1; i <= num; i++)
//{
//    if (num % i == 0)
//    {
//        count++;
//    }
//}
//if (count == 2)
//{
//    Console.WriteLine("The give number is prime");
//}
//else
//{
//    Console.WriteLine("Not prime");
//}

//Amstrong
//int num1 = int.Parse(Console.ReadLine());
//int n;
//double c = 0, sum = 0;
//n = num1; int temp = num1;
//while (n != 0)
//{
//    c = c + 1;
//    n /= 10;
//}
//while (num1 > 0)
//{
//    int r = num1 % 10;
//    sum = sum + Math.Pow(r, c);
//    num1 /= 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("The given number is amstrong");
//}
//else
//{
//    Console.WriteLine("Not Amstrong");
//}

//Palindrome
//int num = int.Parse(Console.ReadLine());
//int temp = num,sum=0;
//while(num> 0)
//{
//    sum = sum * 10 + num % 10;
//    num/= 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("The given number is palindrome");
//}
//else
//{
//    Console.WriteLine("Not a plindrome");
//}

//Adam Number

using Practical_2;

ClassB b = new ClassB();
//b.AdamNum();
//b.Factorial();
//b.Fibonacci();
b.StringReverse();



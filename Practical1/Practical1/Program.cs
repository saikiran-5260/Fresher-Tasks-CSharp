



using Practical1;

ClassA classA = new ClassA();
classA.PrimeNumber();
classA.Palindrome();
classA.AdamNumber();
classA.AmstrongNumber();
classA.Factorial();
classA.Fibonacci();
classA.FibonacciSeriesOfNthNum();



























//int n1 = 0, n2 = 1, n3;
//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());
////Console.Write(n1+"\t"+n2+"\t");
//ArrayList al = new ArrayList();
//al.Add(n1);
//al.Add(n2);
//for(int i=2; i<num; i++)
//{
//    n3 = n1 + n2;
//    //Console.Write(n3+"\t");
//    al.Add(n3);
//    n1 = n2;
//    n2 = n3;
//}
//Console.Write("Enter the nth number of the series: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("The nth number of the series is: "+ al[n]);



//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());
//int sum = 0;
//int revNum = Reverse(num);
//bool isAdam = Math.Pow(num, 2) == Reverse((int)Math.Pow(revNum, 2));
//if (isAdam == true)
//{
//    Console.WriteLine("The given number is Adam");
//}
//else
//{
//    Console.WriteLine("The given number is not Adam");
//}

//int Reverse(int num)
//{
//    int result = 0;
//    while (num > 0)
//    {

//        result = (result * 10) + num % 10;
//        num = num / 10;
//    }
//    return result;
//}






//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());
//int r,revNum=0, sum = 0,revSum = 0;
//int numSquare = (int)Math.Pow(num, 2);

//while(num > 0)
//{
//    r = num % 10;
//    sum = (sum * 10) + r;
//    num=num/10;
//    revNum = sum;
//}
//int RevNumSquare = (int)Math.Pow(revNum, 2);
//while(RevNumSquare > 0)
//{
//    r = RevNumSquare % 10;
//    revSum = (revSum * 10) + r;
//    RevNumSquare = RevNumSquare/10;
//}
//if (numSquare == revSum)
//{
//    Console.WriteLine("The given number is adam number");
//}
//else
//{
//    Console.WriteLine("The given number is not adam number");
//}





//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());
//int fact = 1;
//for(int i = 1; i <= num; i++)
//{
//    fact = fact * i;
//}
//Console.WriteLine("The factorial of given number is: {0}",fact);





//Console.Write("Enter the number: ");
//int n = int.Parse(Console.ReadLine());
//int r, temp, sum = 0;
//temp = n;
//while(n > 0)
//{
//    r = n % 10;
//    sum = (sum * 10) + r;
//    n= n / 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("The given number is palindrome");
//}
//else
//{
//    Console.WriteLine("The given number is not palindrome");
//}





//Console.Write("Enter the number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int r, temp, sum = 0;
//temp = n;
//while(n > 0)
//{
//    r = n % 10;
//    sum+= r*r*r;
//    n= n / 10;
//}
//if (temp == sum)
//{
//    Console.WriteLine("The given number is amstrong");
//}
//else
//{
//    Console.WriteLine("The given number is not amstrong");
//}




//Console.Write("Enter a number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for(int i = 1;i< num+1; i++)
//{
//    if (num % i == 0)
//    {
//        count++;
//    }
//}
//if (count == 2)
//{
//    Console.WriteLine("The given number is prime");
//}
//else
//{
//    Console.WriteLine("Not a prime number");
//}




class LargestOfThreeNumbers
{
    static void Main()
    {
        int num1 = 60;
        int num2 = 123;
        int num3 = 45;
        int greatestNum = 0;
        if (num1 > num2)
            if (num1 > num3)
                greatestNum = num1;
            else
                greatestNum = num3;
        else
            if (num2 > num3)
            greatestNum = num2;
        else

            Console.WriteLine("Greatest Number: " + greatestNum);
        Console.ReadKey();
    }
}
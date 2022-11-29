class Sample
{
    public int Factorial(int num )
    {
        if(num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num-1);
        }
    }
}
class Factorial
{
    public static void Main()
    {
        Sample s = new Sample();

        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        double fact = s.Factorial(number);
        Console.WriteLine("Factorial is: " + fact);
        Console.ReadKey();
    }
}
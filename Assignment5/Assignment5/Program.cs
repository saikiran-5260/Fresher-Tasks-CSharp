
class Assignment5
{
    static void Main()
    {
        Number a = new Number();
        a.SetValue(2);
        System.Console.WriteLine("Number: " + a.GetValue());
        System.Console.WriteLine("Is Number is Zero: " + a.IsZero());
        System.Console.WriteLine("Is Number is Positive: " + a.IsPositive());
        System.Console.WriteLine("Is Number is Positive: " + a.IsNegative());
        System.Console.WriteLine("Is Number is Prime: " + a.IsOdd());
        System.Console.WriteLine("Is Number is Prime: " + a.IsEven());
        System.Console.WriteLine("Is Number is Prime: " + a.IsPrime());
        System.Console.WriteLine("Is Number is Prime: " + a.IsPrime());
        System.Console.WriteLine("Count of Value: " + a.GetCountOfDigits());
        Number b = new Number();
        System.Console.WriteLine(type(b.Value));

        System.Console.ReadKey();
    }
    
}
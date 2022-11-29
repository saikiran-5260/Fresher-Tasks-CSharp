public class AreaOfCircle
{
    public static void Main()
    {
        const double pi = 3.14159;
        System.Console.Write("Enter Radius:");
        double radius = Convert.ToDouble(System.Console.ReadLine());
        double Area = pi * radius * radius;
        System.Console.WriteLine("Area of circle:" + Area);
        System.Console.ReadKey();
    }
}

public class ConvertingFeetToCm
{
    static void Main()
    {

        const int OneFeet = 12;
        const double OneInch = 2.54;
        System.Console.Write("Enter feet:");
        int feet = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter Inch:");
        int Inch = Convert.ToInt32(System.Console.ReadLine());
        int total_inches = (feet * OneFeet) + Inch;
        double InchToCm = total_inches * OneInch;
        System.Console.WriteLine("ConvertingFeetToCm: " + InchToCm);
        System.Console.ReadKey();


    }

}


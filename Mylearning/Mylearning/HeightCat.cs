using System.Xml.Schema;

class HeightCat
{
    static void Main()
    {
        const double OneInch = 2.54;
        Console.WriteLine("Enter Inches:");
        int Inches = Convert.ToInt16(Console.ReadLine());
        double TotalCm = Inches * OneInch;
        if (TotalCm < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if (TotalCm > 150 & TotalCm < 165)
        {
            Console.WriteLine("Average Height");
        }
        else if (TotalCm > 165 & TotalCm < 195)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal Height");
        }
        Console.ReadKey();

    }
}
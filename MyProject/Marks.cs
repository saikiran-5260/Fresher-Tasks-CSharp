
namespace MyProject
{
    public class Marks 
    {
        public static int rollnumber, pc, ch, mt;
        public static int total = 0;
        public static string name=" ";
        public void ReadingDetails()
        {
            
            Console.WriteLine("Enter the rollnumber");
            rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the marks for Physics");
            pc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks for Chemistry");
            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks for Mathematics");
            mt = Convert.ToInt32(Console.ReadLine());
        }
       
    }
}

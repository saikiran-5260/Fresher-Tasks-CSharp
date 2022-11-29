class ConvertingSecToMins
{
    static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            const int OneMin = 60;
            const int OneHr = 60 * OneMin;
            const int OneDay = 24 * OneHr;
            Console.Write("Enter Seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int remaining_seconds = seconds;
            int days = seconds / OneDay;
            remaining_seconds -= days * OneDay;

            int hours = remaining_seconds / OneHr;
            remaining_seconds -= hours * OneHr;

            int minutes = remaining_seconds / OneMin;
            remaining_seconds -= minutes * OneMin;

            Console.WriteLine(days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds");
            Console.ReadLine();
        }
    }
}
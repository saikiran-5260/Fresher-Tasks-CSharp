class StudentMarks
{
    public void getMarks(params int[] marks )
    {
        double avgMarks = calculateAvg( marks );
        Console.WriteLine("Avg marks: " + avgMarks);


        static double calculateAvg(int[] marks)
        {
            int totalMarks = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks += marks[i];
                Console.WriteLine($"marks{i + 1}: " + marks[i]);
            }
            double avg;
            avg = (double) (totalMarks)/marks.Length;
            return avg;
        }
    }
}
class Program
{
    static void Main()
    {
        StudentMarks s = new StudentMarks();
        s.getMarks(80,45,71);
        Console.ReadKey();
    } 
}
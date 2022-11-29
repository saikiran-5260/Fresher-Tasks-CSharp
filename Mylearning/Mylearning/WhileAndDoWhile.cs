class WhileAndDoWhileForLoops
{
    static void Main()
    {
        int number = 1;

        while (number <= 10)
        {
            System.Console.Write(number);
            number++;
        }
        System.Console.ReadLine();


        int i = 1;
        do
        {
            System.Console.WriteLine(i);
            System.Console.WriteLine("printing i value: " + i);
            i++;
        } while (i <= 10);

        System.Console.ReadKey();


        for (int j = 0; j <= 10; j++)
        {
            Console.WriteLine("i value is: " + j);
        }
        Console.ReadLine();
    }
}
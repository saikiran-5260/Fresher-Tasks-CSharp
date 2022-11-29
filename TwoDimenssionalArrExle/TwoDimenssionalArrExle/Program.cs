Console.WriteLine("Two-Dimenssional Array");

Console.WriteLine("\n");
Console.WriteLine("\t");

Console.Write("Enter number of rows: ");
int rowSize = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columnSize = int.Parse(Console.ReadLine());
Console.WriteLine("\t");


string[,] banks = new string[rowSize,columnSize];

for (int i = banks.GetLowerBound(0); i <= banks.GetUpperBound(0); i++)
{
    Console.Write("Please enter bank name: ");
    banks[i, 0] = Console.ReadLine();

    Console.Write("Please enter state: ");
    banks[i, 1] = Console.ReadLine();

    Console.Write("Please enter bank id: ");
    banks[i, 2] = Console.ReadLine();

    Console.Write("Please enter no of barnches available of the bank: ");
    banks[i, 3] = Console.ReadLine();

    Console.Write("Please enter no of accounts availabl in the bank: ");
    banks[i, 4] = Console.ReadLine();
    Console.WriteLine("\n");
}


for (int i = banks.GetLowerBound(0);i<=banks.GetUpperBound(0);i++)
{
    for (int j = banks.GetLowerBound(1); j <= banks.GetUpperBound(1);j ++)
    {
        Console.WriteLine(banks[i,j] + "\t");   
    }
    Console.WriteLine("\n");
}



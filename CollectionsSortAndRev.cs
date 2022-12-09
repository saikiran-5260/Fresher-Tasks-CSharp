


List<int> myList = new List<int> { 9,6,5,49,21,12,94};

myList.Sort();
foreach(int i in myList)
{
    Console.Write(i+"\t");
}
Console.WriteLine("\n");

myList.Reverse();
foreach(int j in myList)
{
    Console.Write(j+"\t");
}
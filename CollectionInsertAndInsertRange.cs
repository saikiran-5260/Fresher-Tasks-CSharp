


List<int> myList = new List<int>(10) { 1, 2, 3 };

myList.Insert(0, 5);

foreach(int i in myList)
{
    Console.Write(i+" ");
}
Console.WriteLine("\n");
List<int> myList1 = new List<int>(10) { 4,5,6 };
myList.InsertRange(3, myList1);
foreach(int j in myList)
{
    Console.Write(j+" ");
}




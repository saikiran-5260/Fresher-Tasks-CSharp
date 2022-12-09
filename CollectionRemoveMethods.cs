

List<int> myList = new List<int> { 1, 2, 3,4,5,6,7 };

// Remove function
myList.Remove(1);
foreach (int i in myList)
{  
    Console.WriteLine(i);
}

//RemoveAt function
Console.Write("Enter Index: ");
int index = int.Parse(Console.ReadLine());
if(index < myList.Count)
{
    myList.RemoveAt(index);
    Console.WriteLine("Index is called");
}
Console.WriteLine("\n");

foreach (int j in myList)
{
    Console.WriteLine(j);
    
}
Console.WriteLine("\n");

//Remove Range function

myList.RemoveRange(0,1);
foreach(int k in myList)
{
    Console.WriteLine(k);
}
Console.WriteLine("\n");

//RemoveAll function

myList.RemoveAll(x => x <= 5);
foreach(int l in myList)
{
    Console.WriteLine(l);   
}
Console.WriteLine("\n");

// Clear function
myList.Clear();
myList.Add(100);
myList.Add(200);
foreach(int m in myList)
{
    Console.WriteLine(m);
}
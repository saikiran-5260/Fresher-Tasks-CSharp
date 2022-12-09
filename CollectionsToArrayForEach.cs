

List <int> myList = new List<int> { 12,13,14,15,16,17,18,19,20};

int [] newArr=myList.ToArray();

foreach(int i in newArr)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");
List<string> myStringList = new List<string>(4){"sai","Kiran","Shanmukha","Pithani"};
myStringList.ForEach(el => Console.WriteLine(el));
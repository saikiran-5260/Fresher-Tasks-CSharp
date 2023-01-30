using System.Collections;
//List Generic collection class
List<int> list = new List<int>(3);
list.Add(1);
list.Add(2);
list.Add(3);
Console.WriteLine("Capacity of list is: " + list.Capacity);
list.Add(4);
list.Add(5);
Console.WriteLine("Capacity of list is: " + list.Capacity);
list.Remove(1);
list.RemoveAt(0);
list.RemoveRange(0, 1);
list.Add(6);
bool e = list.Contains(1);
list.AddRange(list);
Console.WriteLine(e);
double avg = list.Average();
Console.WriteLine(avg);
foreach (int i in list)
{
    Console.WriteLine("values in the list are : " + i);
}

Console.WriteLine("\n");

//Dictionary Generic collection class
Dictionary<int,string> d= new Dictionary<int,string>();
d.Add(101, "sai");
d.Add(102, "Kiran");
d.Add(103, "Pithani");
d.Add(104, "Abhinav");
d.Add(105, "Praveen");
d.Remove(101);
foreach (KeyValuePair<int,string> i in d)
{
    Console.WriteLine(i.Value);
}
string k = d[102];
Console.WriteLine(k);
Console.WriteLine(d.TryGetValue(102,out k));

Console.WriteLine("\n");
//last in first out
//Stack Generic collection class
Stack<int> stack = new Stack<int>(5);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);
stack.Push(7);
foreach(int i in stack)
{
    Console.WriteLine(i);
}
Console.WriteLine(stack.Count);
int p = stack.Pop();
Console.WriteLine("\n"+p);
int peek = stack.Peek();
Console.WriteLine(peek);//gives the first element without deleting the first element
Console.WriteLine(stack.Contains(8));

Console.WriteLine("\n");
//first in first out
//Queue Generic collection class
Queue<string> strings= new Queue<string>(3);
strings.Enqueue("hello");
strings.Enqueue("Sai");
strings.Enqueue("Kiran");
strings.Enqueue("Good");
strings.Enqueue("Morning");
foreach(string s in strings)
{
    Console.Write(s+" ");
}
Console.WriteLine();
Console.WriteLine(strings.Contains("hello")); 
Console.WriteLine(strings.Dequeue());
Console.WriteLine(strings.Contains("hello"));
Console.WriteLine(strings.Count);

Console.WriteLine("\n");
//Hashset Generic collection class
HashSet<string> set = new HashSet<string>();
set.Add("hello");
set.Add("Abhinav");
set.Add("Good");
set.Add("morning");
foreach(string s in set)
{
    Console.Write(s+" ");
}

Console.WriteLine("\n");
SortedList<int,string> sl = new(3);
sl.Add(130, "sai");
sl.Add(128, "kiran");
sl.Add(126, "praveen");
sl.Add(129, "Abhinav");
sl.Add(121, "Matt");
sl.Add(135, "Scott");
sl.Add(125, "Tony");
foreach(KeyValuePair<int,string> kv in sl)
{
    Console.WriteLine(kv.Value+" ");
}
Console.WriteLine(sl.Capacity);

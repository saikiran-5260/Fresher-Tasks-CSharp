


//Last In First Out


Stack<int> s = new Stack<int>();
s.Push(60); // third 
s.Push(70); // 70 second
s.Push(80); // 80 will be printed first              

foreach(int i in s)
{
    Console.WriteLine(i);
}

int p = s.Pop();
Console.WriteLine("pop ele: "+p); // removes the last element from the stack

int pk =s.Peek();
Console.WriteLine("peek ele: "+pk); // Gets the last element without deleting.





using System.Collections.Concurrent;

Queue<int> q = new Queue<int>();

q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(5);
q.Enqueue(6);
q.Enqueue(7);

foreach(int i in q)
{
    Console.WriteLine(i);
}

int dq = q.Dequeue();
Console.WriteLine("dequeue: "+dq);

int dq1  = q.Dequeue();
Console.WriteLine("dequeue: "+dq1);

int pk = q.Peek();
Console.WriteLine("Peek element: "+pk);

foreach(int j in q)
{
    Console.WriteLine(j);
}
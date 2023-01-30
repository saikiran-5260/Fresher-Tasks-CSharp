

using AnonymousMethod;
//Anonymous Method
myDel del = delegate(int x, int y)
{
    return x + y; 
};


int result = del.Invoke(5, 6);
Console.WriteLine(result);

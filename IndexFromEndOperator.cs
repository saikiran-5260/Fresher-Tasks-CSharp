


int[] a= new int[6] { 3,5,8,9,10,2};

int result = a[^1];
Console.WriteLine(result);

//range operator
int[] result1 = a[2..5];

foreach (int i in result1)
{
    Console.WriteLine(i);   
}
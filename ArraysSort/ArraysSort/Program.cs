int[] myArr = new int[6] { 5, 3, 6, 2, 4, 1 };

int[] newArr = new int[myArr.Length];

newArr = myArr;
int minVal = 0;

Array.Sort(myArr);

foreach (int i in myArr)
{
    Console.WriteLine(i);
}

Array.Reverse(myArr);

foreach (int j in myArr)
{
    Console.WriteLine(j);
}

//int[] arr = { 78, 55, 45, 98, 13 };
//int temp;
//for (int j = 0; j <= arr.Length - 2; j++)
//{
//    for (int i = 0; i <= arr.Length - 2; i++)
//    {
//        if (arr[i] > arr[i + 1])
//        {
//            temp = arr[i + 1];
//            arr[i + 1] = arr[i];
//            arr[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Sorted desc:");
//foreach (int p in arr)
//    Console.Write(p + " ");
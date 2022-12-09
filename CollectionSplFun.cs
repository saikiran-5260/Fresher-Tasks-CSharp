


List<int> myList = new List<int> { 10, 20,30,40,50,60,70,80,90 };

// IndexOf function
int Index  = myList.IndexOf(30);
Console.WriteLine("Index of given element: {0}", Index);

//BinarySearch of myList

int I = myList.BinarySearch(70);
Console.WriteLine("Binary Search index is: {0} ", I);

//Contains fuction
bool exits = myList.Contains(40);
Console.WriteLine("The given exits in the list: {0}",exits);

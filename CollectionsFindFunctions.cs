


List<int> marks = new List<int> {40 , 24, 95,74,35,50,81 };

//Exists Function
bool passORFail = marks.Exists(x => x < 35);
if(passORFail == true)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Pass");
}
marks.Add(20);
Console.WriteLine("\n");
//value of first failed marks Find Function
int matchEle = marks.Find(m => m<35);
Console.WriteLine(matchEle);
Console.WriteLine("\n");
//FindIndex Function
int Index  = marks.FindIndex(m => m < 35);
Console.WriteLine(Index);
Console.WriteLine("\n");
//FindLast function
int lastMatach = marks.FindLast(m => m < 35);
Console.WriteLine(lastMatach);
Console.WriteLine("\n");
//FindLastIndex fuction
int lastMatachIndex = marks.FindLastIndex(m => m < 35);
Console.WriteLine(lastMatachIndex);
Console.WriteLine("\n");
//FindAll Function
List<int> allFailedMarks = marks.FindAll(m => m < 35);
foreach(int failmark in allFailedMarks)
{
    Console.Write(failmark+" ");
}
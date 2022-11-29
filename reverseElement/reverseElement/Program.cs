

// Reverse of the element
using System.Text;

int[] myArr = new int[] { 1, 2, 3, 4, 5, 6 };

for (int i = myArr.GetUpperBound(0); i >= myArr.GetLowerBound(0); i--)
{
    Console.Write(myArr[i] + "\t");
}

Console.WriteLine("\n");

char[] newArr = new char[] { 's', 'a', 'i', 'k', 'i', 'r', 'a', 'n' };


for (int i = newArr.GetUpperBound(0); i >= newArr.GetLowerBound(0); i--)
{
    Console.Write(newArr[i]);

}

//Using IndexOf
Console.WriteLine("\t");
int IndOfAnElement = Array.IndexOf(newArr, 'a', 2);
Console.WriteLine(IndOfAnElement);

//Using lastIndexOf
int lastIndOfAnElement = Array.LastIndexOf(newArr, 'a', 5);
Console.WriteLine(lastIndOfAnElement);

//Using IndexOf
Console.WriteLine("\t");
int upIndOfAnElement = Array.IndexOf(newArr, 'n');
Console.WriteLine(upIndOfAnElement);

//Using lastIndexOf
int upLastIndOfAnElement = Array.LastIndexOf(newArr, 'a');
Console.WriteLine(upLastIndOfAnElement);


// Using of stringBuilder
StringBuilder s = new StringBuilder("Hello ");
s.Append("sai kiran");
//Console.WriteLine(s);


//split fuction
string s1 = "1,2,3,4";

string[] s2 = s1.Split(",");

foreach (string s3 in s2)
{
    Console.WriteLine(s3);
}

//substring
string s4 = "I came to the office today. The office looks empty";


Console.WriteLine(s4.Substring( s4.IndexOf(".") + 2));

//Trim fuction

string s5 = "                    Today i went to the office on bus                      ";
Console.WriteLine(s5);
string s6 = s5.Trim();
Console.WriteLine(s6);
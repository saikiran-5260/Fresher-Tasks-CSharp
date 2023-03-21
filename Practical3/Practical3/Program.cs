


/*Viinodi kumara yadav
Output

Vinod kumar  yadv*/



string input = "Viinodi kumara yadav";
string[] str = input.Split(" ");
List<string> str2 = new List<string>();
string resultString = "";
foreach (string str1 in str)
{
    Console.WriteLine(str1.Length);
    string result = " ";
    for (int i = 0; i < str1.Length; i++)
    {
        
        if (!result.Contains(str1[i]))
        {
            result += str1[i];
        }
    }
    resultString += result;
}
Console.WriteLine(resultString);




//string[] resultStringArray = str2.ToArray();

//foreach(string str3 in resultStringArray)
//{
//    resultString += str3;
//}
//Console.WriteLine(resultString);


//string[] str = input.Split(" ");
//string resultString = string.Empty;
//foreach( string str1 in str)
//{
//    for (int i = 0; i < str1.Length; i++)
//    {
//        if (!resultString.Contains(str1[i]))
//        {
//            resultString += str1[i];
//        }
//    }
//}

//Console.WriteLine(resultString);

//var uniqueCharArr = input.ToCharArray().Distinct().ToArray();
//var result = new string(uniqueCharArr);
//Console.WriteLine(result);

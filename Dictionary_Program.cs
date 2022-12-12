

//Dictionary Example
Dictionary<int, object> marksOfSub = new Dictionary<int,object>() {
    {11000001, "Empolyee1"},
    {11000002, "Employee2"},
    {11000003, "Employee3"},
    {11000004, "Employee4"},
    {11000005, "Employee5"},
    {11000006, "Employee6"},
    {11000007, "Employee7"},

};
marksOfSub.Add(11000008, "Employee8") ;
marksOfSub.Add(11000009, "Employee9");
marksOfSub.Add(11000010, "Employee10");
marksOfSub.Add(11000011, "Employee11");
marksOfSub.Remove(11000007);

Console.Write("Enter Employee Id: "); 
int Emp = int.Parse(Console.ReadLine());
Console.WriteLine(marksOfSub.ContainsKey(Emp));
foreach (KeyValuePair<int, object> marks in marksOfSub)
{
    
    if (Emp != 0 && marks.Key == Emp)
    {
        Console.WriteLine("The Employee you requested is: {0}", marks.Value);
    }
    
}

marksOfSub.Clear();


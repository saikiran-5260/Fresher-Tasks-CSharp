



SortedList<int, string> sl = new SortedList<int, string>() {
    {48,"Telugu" },
    {23,"Hindi" },
    {66,"English" },
    {99,"Maths" }
};
sl.Add(21, "Science");
sl.Add(43, "Social");
sl.Add(49, "Computers");
sl.Remove(21);
foreach (KeyValuePair<int,string> ele in sl)
{
    Console.WriteLine(ele.Key + "," + ele.Value);
}

Console.WriteLine(sl.ContainsKey(66));
Console.WriteLine(sl.ContainsValue("Maths"));
Console.WriteLine(sl.IndexOfKey(49));
Console.WriteLine(sl.IndexOfValue("Hindi"));


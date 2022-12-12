


HashSet<string> hs = new HashSet<string>() { 
    "Good Moring",
    "Team",
    "How did your weekend go?",
    "Please let me know"
};

Console.WriteLine(hs.Count);

hs.Add("Welcome All");

foreach(string h in hs)
{
    Console.WriteLine(h);
}

hs.RemoveWhere(e => e.EndsWith("All"));
Console.WriteLine("\n");
foreach(string st in hs)
{
    Console.WriteLine(st);
}
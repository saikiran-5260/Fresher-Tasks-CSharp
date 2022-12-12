


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


Console.WriteLine("\n");
HashSet<string> ss = new HashSet<string>() {"First Name", "Shanmukha","Sai","Kiran","Pithani" };
HashSet<string> ss1 = new HashSet<string>() { "Last Name", "Pithani", "Shanmukha","Sai","Kiran" };

ss.UnionWith(ss1);

foreach (string s in ss)
{
    Console.WriteLine(s);
}

Console.WriteLine("\n");
ss.IntersectWith(ss1);

foreach(string s in ss)
{
    Console.WriteLine(s);
}

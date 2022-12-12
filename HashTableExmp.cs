

using System.Collections;

Hashtable hash = new Hashtable() {
    {101,"Employee1" },
    {102,"Employee2" },
    {103,"Employee3" },
    {104,"Employee4" },
    {"Employee5",105},
    {105,"Employee5" }
};

foreach(DictionaryEntry el in hash)
{
    Console.WriteLine(el.Key +" " + el.Value);
}

if (hash[103] is string)
{
    Console.WriteLine(hash[105]);
}

Console.WriteLine("\n"+hash.ContainsKey(104));
Console.WriteLine("\n"+hash.ContainsValue(105));

foreach(var els in hash.Keys)
{
    Console.WriteLine(els);
}
Console.WriteLine("\n");
foreach(var el1 in hash.Values)
{
    Console.WriteLine(el1);
}
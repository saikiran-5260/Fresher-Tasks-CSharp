


//string Myname = "Sai";
//string clone = (string)Myname.Clone();

using ICloneableInterfaceImplementation;

sample s = new sample();
s.Name = "Sai";
sample clone = (sample)s.Clone();
Console.WriteLine(clone.Name);

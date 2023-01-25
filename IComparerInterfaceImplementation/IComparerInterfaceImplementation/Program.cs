



using IComparerInterfaceImplementation;
using System.Collections.Generic;


student s1 = new student() { Sid = 106, Name = "student1", Sclasss = 6, marks = 473.00f};
student s2 = new student() { Sid = 108, Name = "student2", Sclasss = 6, marks = 499.00f};
student s3 = new student() { Sid = 116, Name = "student3", Sclasss = 6, marks = 486.50f};
student s4 = new student() { Sid = 102, Name = "student4", Sclasss = 6, marks = 376.99f};
student s5 = new student() { Sid = 112, Name = "student5", Sclasss = 6, marks = 453.00f};

List<student> stu = new List<student>() { s1,s4,s5};

string name = stu.First(x => x.Sid == 106).Name;
Console.WriteLine(name);
stu.Add(s2);stu.Add(s3);
CompareStudent cs = new CompareStudent();

stu.Sort(cs);
foreach(student st in stu)
    Console.WriteLine(st.Sid+"\t"+st.Name+"\t"+st.Sclasss+"\t"+st.marks);
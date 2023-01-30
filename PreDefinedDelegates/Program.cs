

using PreDefinedDelegates;

//Sample s = new Sample();
//AddNumbers add = Sample.AddNumbers;
//double result = add.Invoke(10, 20.6f, 65.76);
//Console.WriteLine(result);

//AddNumbers1 add1 = Sample.AddNumbers1;
//add1.Invoke(10, 20.6f, 65.76);

//Status s1 = Sample.Status;
//bool status = s1.Invoke("Hello");
//Console.WriteLine(status);

Func<int, float, double, double> func = Sample.AddNumbers;
double result = func.Invoke(10, 20.6f, 65.76);
Console.WriteLine(result);

Action<int, float, double> ac = Sample.AddNumbers1;
ac.Invoke(10, 20.6f, 65.76);

Predicate<string> p = Sample.Status;
bool result2 = p.Invoke("Sai");
Console.WriteLine(result2);


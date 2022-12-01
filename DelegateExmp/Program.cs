using System;
using ClassLibrary1;

Sample s = new Sample();


MyDelegateType myDelegate =new MyDelegateType(s.DiscountCal);

Console.WriteLine(myDelegate.Invoke(2000, 1000));
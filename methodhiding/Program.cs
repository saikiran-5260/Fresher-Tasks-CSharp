

using MethodHidingExmp;
using System;

Account a = new Account();
Console.Write("Enter account holder name: ");
a.accName = Console.ReadLine();
Console.Write("Enter account holder location: ");
a.location = Console.ReadLine();
a.accNumber = 101;
a.accBalance = 10000;
a.DisplayDetails();
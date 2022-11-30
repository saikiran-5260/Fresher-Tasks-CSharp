using ClassLibrary1;
using ExtentionMethodExmp;
using System;


Product p = new Product() { productCost=10000,productDiscount=25};

Console.WriteLine(p.GetDiscount());
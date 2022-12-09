

using PolymorphismExmp;

MethodOverLoading mol = new();
mol.DisplayDetails();
mol.DisplayDetails(100000);
mol.DisplayDetails(100000,"KTM");
mol.DisplayDetails(100000, "Repsol",10000);

ChildClass child= new ChildClass();
child.DisplayDetails(100000, "Benili", 10000, 1000);



using DelegateExmp;

DelegateExmp.Delegate dl = new();
del d = new(DelegateExmp.Delegate.Add);
d += DelegateExmp.Delegate.Mul;
d(10, 20);





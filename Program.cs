
using PaymentOptionsOverLoading;

PaymentMethods pm = new PaymentMethods();

pm.PaymentMethod();
pm.PaymentMethod(pm.nb);
pm.PaymentMethod(pm.nb,pm.c);
pm.PaymentMethod(pm.nb, pm.c, pm.cc);
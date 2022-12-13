

using ComplexTypeParameter;

ComplexType ct = new ComplexType();
ct.GetDetails("Shanmukha Sai Kiran Pithani", 110005260, "Hyderabad");
ct.AddDetails(ct,"40000", "oct 17");
ComplexType ct1= new ComplexType();
ct1.GetDetails("Abinav Srivastava", 110005258, "Banglore");
ct1.AddDetails(ct1, "50000","17 sep");
ComplexType ct2 = new ComplexType();
ct2.GetDetails("Sujitha", 110005257, "Banglore");
ct2.AddDetails(ct2,"60000", "jun 20");
ComplexType ct3 = new ComplexType();
ct3.GetDetails("Praveen", 110005256, "Banglore");
ct3.AddDetails(ct3,"70000", "jun 10");
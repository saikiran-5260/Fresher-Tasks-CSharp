using ClassLibrary1;

structure s = new structure();
s.GetPin = 230;
s.AccountHolderName = "shanmukha sai kiran Pithani";

Console.WriteLine("account holder name is: "+ s.AccountHolderName);
Console.WriteLine("Pin updated is: " + s.GetPin);


User<string> user = new User<string>();
user.RegistrationStatus = "1234";
Console.WriteLine(user.RegistrationStatus.Length);
Console.WriteLine(user.RegistrationStatus.GetType());


User<int> user1 = new User<int>();
user1.RegistrationStatus = 1234;
Console.WriteLine(user1.RegistrationStatus);
Console.WriteLine(user1.RegistrationStatus.GetType());

using Task1;

Properties p = new Properties(12345,100000,"sai kiran", "kiran@gmail.com");
p.DisplayDetails();
int balance = p.accBalance;

if(balance == -100)
{
    Console.WriteLine("Entered password is invalid");
}
else
{
    Console.WriteLine(balance);
}
Console.WriteLine(p.accId);
using BankAccountAssignment;

BankAccount account = new BankAccount();
account.CreateAccount();
Console.Write("Please enter deposite amount:");
account.amount = int.Parse(Console.ReadLine());
account.Deposite(account.amount);
Console.WriteLine("create pin:");
account.PIN = Console.ReadLine();
do
{
    Console.Write("Please enter withdraw amount:");
    account.amount = int.Parse(Console.ReadLine());
    account.WithDraw(account.amount);
} while (account.amount > account.accountBalance);
account.CloseAccount();



namespace AbstractClassTask
{
    public class SalaryAccount : BankAccount
    {
        public override void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            int amount  = int.Parse(Console.ReadLine());
            if(amount >= accBal)
            {
                Console.WriteLine("insufficient funds check the amount entered and your account balance is: " + accBal);
            }
            else
            {
                Console.WriteLine("Withdraw method is initiated: ");
                accBal = accBal-amount;
                Console.WriteLine("The withdraw is successful the balance after withdraw is: "+ accBal);
            }
        }

        public override void Transfer()
        {
            Console.Write("\nEnter amount to Transfer: ");
            int amount = int.Parse(Console.ReadLine());

            if (amount >= accBal)
            {
                Console.WriteLine("\ninsufficient funds check the amount entered and your account balance is: " + accBal);
            }
            else
            {
                Console.WriteLine("Tranfer method is initiated: ");
                accBal = accBal - amount;
                Console.WriteLine("The Transfer is successful the balance after withdraw is: " + accBal);
            }
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\nThe account details after the successful tranfer and withdraw is: \n{0}\n{1}\n{2}",accId,accBal,accName);

        }
    }
}

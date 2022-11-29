using System;
using System.Security.Cryptography.X509Certificates;

class MyBankPage
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine("*********MY OWN BANK********");
        Console.WriteLine(":: LOGIN PAGE::");
        Console.WriteLine("PRESS ENTER TO EXIT");
        logInSection:
        Console.WriteLine("\n");
        string username, password;
        Console.Write("USER NAME:");
        username = Console.ReadLine();
        if (username != "")
        {
            Console.Write("PASSWORD:");

        }
        password = Console.ReadLine();
        if (username == "Shanmukhasaikiran" & password == "XXXXXXXXXX")
            
        {
            int userChoise = -1;

            do
            {
            Console.WriteLine("\n");
            Console.WriteLine("LOGIN SUCCESSFUL");
            Console.WriteLine("PLEASE CHOOSE THE OPTIONS BELOW");
            Console.WriteLine("\n");

            
            Console.WriteLine("::MAIN MENU::");
            Console.WriteLine("1.CUSTOMER");
            Console.WriteLine("2.ACCOUNTS");
            Console.WriteLine("3.FUND TRANSFER");
            Console.WriteLine("4.FUND TRANSFER STATEMENT");
            Console.WriteLine("5.ACCOUNT STATEMENT");
            Console.WriteLine("0.EXIT");
            Console.WriteLine("\n");
                
            Console.WriteLine();

            Console.WriteLine("PLEASE ENTER YOUR CHOICE");
            userChoise = int.Parse(Console.ReadLine());
            if (userChoise >5)
                    {
                    Console.WriteLine("\n");
                    Console.WriteLine("YOUR CHOICE EXEEDS THE LIMIT OF LIST AVAILABLE");
                    }

                switch (userChoise)
            {
                case 1: IfUserChoiceIsCustomer(); break;
                case 2: IfUserChoiceIsAccounts(); break;
                case 3: IfUserChoiceIsFundTranfer(); break;
                case 4: IfUserChoiceIsFundTranferStatement(); break; 
                case 5: IfUserChoiceIsAccountStatement(); break;
                case 0: Console.WriteLine("THANK YOU FOR VISITING COME BACK AGAIN TO ENJOY THE BENIFITS:"); break;
            }

        }while (userChoise != 0) ;
        }
        else
        {
            Console.WriteLine("YOU HAVE ENTERED INVALID CREDENTIALS");
            goto logInSection;

        }
        Console.ReadKey();
    }
    static void IfUserChoiceIsCustomer()
    {
        int IfUserChoiceIsCustomer = -1;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("::CUSTOMERS MENU::");
            Console.WriteLine("1.ADD CUSTOMER");
            Console.WriteLine("2.DELETE CUSTOMER");
            Console.WriteLine("3.UPDATE CUSTOMER");
            Console.WriteLine("4.VIEW CUSTOMER");
            Console.WriteLine("5.BACK TO MAIN MENU");

            switch (IfUserChoiceIsCustomer)
            {
                case 1: Console.WriteLine("ADDING NEW USER");break;
                case 2: Console.WriteLine("DELETING USER"); break;
                case 3: Console.WriteLine("UPDATING USER"); break;
                case 4: Console.WriteLine("VIEWING USER"); break;
                case 5: Console.WriteLine("5.BACK TO MAIN MENU"); ; break;
            
            }
            Console.Write("ENTER YOUR CHOICE: ");
            IfUserChoiceIsCustomer = Convert.ToInt16(Console.ReadLine());
        } while (IfUserChoiceIsCustomer != 0);
        Console.ReadKey();
    }
    static void IfUserChoiceIsAccounts()
    {
        int IfUserChoiceIsAccounts = -1;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("::ACCOUNTS MENU::");
            Console.WriteLine("1.ADD ACCOUNT");
            Console.WriteLine("2.DELETE ACCOUNT");
            Console.WriteLine("3.UPDATE ACCOUNT");
            Console.WriteLine("4.VIEW ACCOUNT");
            Console.WriteLine("5.BACK TO MAIN MENU");

            switch (IfUserChoiceIsAccounts)
            {
                case 1: Console.WriteLine("ADDING NEW ACCOUNT"); break;
                case 2: Console.WriteLine(" DELETING ACCOUNT"); break;
                case 3: Console.WriteLine("UPDATING ACCOUNT"); break;
                case 4: Console.WriteLine("VIEWING NEW ACCOUNT"); break;
                case 5: Main(); break;

            }
            Console.WriteLine("ENTER YOUR CHOICE: ");
            IfUserChoiceIsAccounts = int.Parse(Console.ReadLine());
        } while (IfUserChoiceIsAccounts != 0);
        Console.ReadKey();
    }
    static void IfUserChoiceIsFundTranfer()
    {
        int IfUserChoiceIsFundTranfer = -1;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("::FUNDTRANSFER MENU::");
            Console.WriteLine("1.SELECT BENIFICIARY ACCOUNT");
            Console.WriteLine("2.ENTER AMOUNT");
            Console.WriteLine("3.IFSC CODE");
            Console.WriteLine("4.ACCOUNT SUMMARY BEFORE SUBMITTION");
            Console.WriteLine("5.BACK TO MAIN MENU");

            switch (IfUserChoiceIsFundTranfer)
            {
                case 1: Console.WriteLine("BENIFICIARY ACCOUNT SELECTION"); break;
                case 2: Console.WriteLine("ENTER AMOUNT FOR TRANSFERING"); break;
                case 3: Console.WriteLine("IFSC VALIDATION"); break;
                case 4: Console.WriteLine("SUBMITTION FOR TRANSFER"); break;
                case 5: Main(); break;

            }
            Console.WriteLine("ENTER YOUR CHOICE: ");
            IfUserChoiceIsFundTranfer = int.Parse(Console.ReadLine());
        } while (IfUserChoiceIsFundTranfer != 0);
        Console.ReadKey();
    }
    static void IfUserChoiceIsFundTranferStatement()
    {
        int IfUserChoiceIsFundTranferStatement = -1;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("::ACCOUNT TRANSFERSTATEMENT MENU::");
            Console.WriteLine("1.SELECT MONTH OF STATEMENT");
            Console.WriteLine("2.BACK TO MAIN MENU");

            switch (IfUserChoiceIsFundTranferStatement)
            {
                case 1: Console.WriteLine("MONTH SELECTION"); break;
                case 2: Main(); break;

            }
            Console.WriteLine("ENTER YOUR CHOICE: ");
            IfUserChoiceIsFundTranferStatement = int.Parse(Console.ReadLine());
        } while (IfUserChoiceIsFundTranferStatement != 0);
        Console.ReadKey();
    }
    static void IfUserChoiceIsAccountStatement()
    {
        int IfUserChoiceIsAccountStatement = -1;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("::ACCOUNT STATEMENT MENU::");
            Console.WriteLine("1.CHECK BALANCE");
            Console.WriteLine("2.LAST TRANSACTION");
            Console.WriteLine("3.CONVERT EXISTING AMOUNT TO MOD");
            Console.WriteLine("4.BACK TO MAIN MENU");

            switch (IfUserChoiceIsAccountStatement)
            {
                case 1: Console.WriteLine("ACCOUNT BALANCE"); break;
                case 2: Console.WriteLine("LAST TRANSACTION"); break;
                case 3: Console.WriteLine("MOD CONVERTION"); break;
                case 5: Main(); break;

            }
            Console.WriteLine("ENTER YOUR CHOICE: ");
            IfUserChoiceIsAccountStatement = int.Parse(Console.ReadLine());
        } while (IfUserChoiceIsAccountStatement != 0);
        Console.ReadKey();
    }
}

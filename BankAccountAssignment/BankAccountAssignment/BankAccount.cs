using BankAccountAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAssignment
{
    public class BankAccount
    {
        public int accountBalance, amount;
        public string firstName, lastName, contactNumber, emailId;
        private string _pin;


        //public BankAccount(int pin)
        //{
        //    this.pin = pin;
        //    int confirmPin;
        //    Console.WriteLine("Enter Pin:");
        //    pin = int.Parse(Console.ReadLine());
        //}
        //public int CreatePin
        //{
        //    set
        //    {
        //        if ((Convert.ToString(value)).Length == 4 || (Convert.ToString(value)).Length == 6)
        //        {
        //            Console.WriteLine("Pin is valid and pin created successfully");
        //            _pin = value;
                      
        //        }          
        //        else if (Convert.ToString(value) == "1234ef" || Convert.ToString(value) == "0" || Convert.ToString(value) != "a4")
        //        {
        //            Console.WriteLine("Pin entered does not match requirements please recheck and enter:");
        //        }
        //    }
        //    get
        //    {
        //        return _pin;
        //    }
        //}
        public string PIN
        {
            set
            {
                if (value != null && value != "") //if the value is not null or not empty string
                {
                    if (value.Length == 4 || value.Length == 6) //if the number of characters value is either 4 or 6
                    {
                        bool isValid = true;
                        for (int i = 0; i < value.Length; i++) //loop through each character in the value
                        {
                            if (value[i] < 48 || value[i] > 57) //ASCII codes 48 to 57 are equal to digits (0 to 9)  Refer: https://www.asciitable.com/
                                isValid = false; //if the character is not a digit, make isValid as false
                        }
                        if (isValid)
                            _pin = value; //PIN is valid
                        else
                            System.Console.WriteLine("PIN contains one or more non-digit characters.");
                    }
                    else
                        System.Console.WriteLine("PIN should contain either 4 digits or 6 digits");
                }
                else
                    System.Console.WriteLine("PIN value can't be blank");
            }
            get
            {
                return _pin;
            }
        }

        public void CreateAccount()
        {
            FirstName:
            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();
            if(firstName == "")
            {
                Console.WriteLine("Please enter valid credentials in the section");
                goto FirstName;
                Console.WriteLine("\t");
            }
            LastName:
            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();
            if (lastName == "")
            {
                Console.WriteLine("Please enter valid credentials in the section");
                goto LastName;
                Console.WriteLine("\t");
            }
            ContactNum:
            Console.Write("Enter your contact number:");
            contactNumber = Console.ReadLine();
            if (contactNumber == "")
            {
                
                Console.WriteLine("Please enter valid credentials in the section");
                Console.WriteLine("\t");
                goto ContactNum;
               
            }
            else if (contactNumber.Length > 10)
            {
                Console.WriteLine("Please enter valid contact number");
                Console.WriteLine("\t");
                goto ContactNum;
            }
            EmailId:
            Console.Write("Enter your emailId:");
            emailId = Console.ReadLine();
            if (emailId == "")
            {
                Console.WriteLine("Please enter valid credentials in the section");
                goto EmailId;
                Console.WriteLine("\t");

            }
            Console.WriteLine("\t");
            Console.WriteLine($"Your account with SBI in the name {lastName} {firstName} and " +
                $"contact number {contactNumber} and emailaddress is {emailId} has been created successfully " );
            Console.WriteLine("\t");

        }
        public void Deposite(int amount)
        {
            accountBalance = 0;
            accountBalance = accountBalance + amount;
            Console.WriteLine("account balance after deposite is: {0} ", accountBalance);
            Console.WriteLine("\t");
        }

        //public int CreatPin()
        //{
        //    int enterPin, conformPin;
        //createpin:
        //    Console.WriteLine("Create Pin:");
        //    enterPin = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Confirm Pin:");
        //    conformPin = int.Parse(Console.ReadLine());
        //    if (enterPin == conformPin)
        //    {
        //        pin = enterPin;
        //        return pin;
                
        //    }
        //    else
        //    {
        //        Console.WriteLine("Entered pin does not match please try again:");
        //        goto createpin;
        //    }
        //}
        public void WithDraw(int amount)
        {
                        
                if (accountBalance >= amount)
                {
                    enterPin:
                    int validatePIN = int.Parse(_pin);
                    Console.WriteLine("\t");
                    Console.WriteLine("Enter PIN:");
                    validatePIN = int.Parse(Console.ReadLine());

                    if (validatePIN == int.Parse(_pin))
                    {
                        Console.WriteLine("Please wait untill money comes out of machine");
                        accountBalance = accountBalance - amount;
                        Console.WriteLine("Balance in your account after withdrawl is: " + accountBalance);
                        Console.WriteLine("\t");

                }
                    else
                    {
                        Console.WriteLine("Invalid PIN");
                        Console.WriteLine("\t");
                    goto enterPin;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdraw your account balanc: " + accountBalance);
                    Console.WriteLine("\t");
                }
        }
        public void CloseAccount()
        {
            string choice;
            Console.WriteLine("Enter your choice for closing account? (y/n)");
            choice = Console.ReadLine();

            if(choice == "Yes" || choice == "y" || choice == "YES")
            {
                Console.WriteLine("Your account has been closed sucessfully");
            }
            else
            {
                Console.WriteLine("\t");
                Console.WriteLine("Thankyou for being with us please visit back again");
            }
        }
    } 
}





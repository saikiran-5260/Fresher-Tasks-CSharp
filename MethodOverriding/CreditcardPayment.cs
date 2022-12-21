using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveridingExamp
{
    public class CreditcardPayment : DebitCardPayment
    {
       
        public override void CardPaymentMethod() // performing overiding method while inheriting from debitcardpayment class
        {
            
            Console.WriteLine("Enter your cardNum: ");
            cardNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your card expiry month: ");
            expiryMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your card expiry year: ");
            expiryYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your cvv: ");
            cvv = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name on your card: ");
            nameOncard = Console.ReadLine();

            if (cardNum ==123456789)
            {
                if (expiryMonth == 11)
                {
                    if (expiryYear == 2023)
                    {
                        if (cvv == 321)
                        {
                            if (nameOncard == "kiran")
                            {
                                Console.WriteLine("credit card payment method called: ");
                                Console.WriteLine("Credentials valid");
                            }
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("Credentials invalid");
            }
        }

    }
}





//Console.WriteLine("Enter your cardNum: ");
//double creditCardNum = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter your card expiry month: ");
//int creditExpiryMonth = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your card expiry year: ");
//int creditExpiryYear = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your cvv: ");
//int creditCvv = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter name on your card: ");
//string creditNameOncard = Console.ReadLine();

//if (creditCardNum == 123456789)
//{
//    if (creditExpiryMonth == 11)
//    {
//        if (creditExpiryYear == 2023)
//        {
//            if (creditCvv == 123)
//            {
//                if (creditNameOncard == "kiran")
//                {
//                    Console.WriteLine("credit card crendentials called: ");
//                    Console.WriteLine("Credentials valid");
//                }
//            }

//        }

//    }
//}
//else
//{
//    Console.WriteLine("Credentials invalid:");
//} 

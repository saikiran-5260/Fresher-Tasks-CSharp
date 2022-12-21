using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveridingExamp
{
    public class DebitCardPayment
    {
        public double cardNum;
        public int expiryMonth;
        public int expiryYear;
        public int cvv;
        public string nameOncard;

        public virtual void CardPaymentMethod()
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

            if(cardNum == 987654321)
            {
                if(expiryMonth== 12)
                {
                    if(expiryYear== 2022)
                    {
                        if(cvv == 123)
                        {
                            if(nameOncard == "sai")
                            {
                                Console.WriteLine("Debit card payment method is called: ");
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

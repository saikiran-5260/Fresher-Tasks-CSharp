using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public class ICICI : ICardPayment
    {
        public void CardPayment()
        {
            Console.WriteLine("Enter the details of card");
        }

        public void SendMailAfterTransaction(string message)
        {
            Console.WriteLine("Transaction alert mail from ICICI service");
        }

        public void SendOtpForTransaction()
        {
            Console.WriteLine("Send OTP for successful transaction process");
        }

        public void SendSmsNotificationAfterPayment(string number, string message)
        {
            Console.WriteLine("send message from ICICI service");
        }
    }
}

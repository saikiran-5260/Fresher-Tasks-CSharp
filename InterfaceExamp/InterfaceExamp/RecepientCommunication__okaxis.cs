using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public class RecepientCommunication__okaxis : IGpayPaymentServiceConfiguration
    {
        public void GetRecevingRecepient(string number)
        {
            Console.WriteLine("Enter the Receving recepient number ");
        }
    

        public void SendEmailFromServiceChoosen(string message)
        {
            Console.WriteLine("Transaction alert mail from okaxis");
        }

        public void SendSMSAfterTransaction(string number, string messagae)
        {
            Console.WriteLine("Sending SMS after transaction to the receiver");
        }

            public void SendSMSForBothRecepientsAfterTransaction(string[] numbers, string messagae)
        {
            Console.WriteLine("Transaction alert for both recepients");
        }
    }
}

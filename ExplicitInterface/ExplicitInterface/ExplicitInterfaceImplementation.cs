using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public class ExplicitInterfaceImplementation : ICustomerCommunication, ICardPaymet
    {
        public void CardPayment()
        {
            Console.WriteLine("Verify Card details");
        }

        public void GetRecevingRecepient()
        {
            Console.WriteLine("Recepient payment details");
        }


        void ICustomerCommunication.SendEmailFromServiceChoosen()
        {
            Console.WriteLine("Sending emial trasaction for CustomerCommunication service");
        }

        void ICustomerCommunication.SendSMSAfterTransaction()
        {
            Console.WriteLine("Sending SMS from CustomerCommunication Service");
        }

        void ICustomerCommunication.SendSMSForBothRecepientsAfterTransaction()
        {
            Console.WriteLine("Sending SMS from CustomerCommunication Service for receiver and sender");
        }

        void ICardPaymet.SendEmailFromServiceChoosen()
        {
            Console.WriteLine("Sending emial trasaction for cardpayment service");
        }

        void ICardPaymet.SendSMSAfterTransaction()
        {
            Console.WriteLine("Sending SMS from cardpayment Service");
        }

        void ICardPaymet.SendSMSForBothRecepientsAfterTransaction()
        {
            Console.WriteLine("Sending SMS from cardpayment Service for receiver and sender");
        }



        //public void SendSMSAfterTransaction()
        //{
        //    Console.WriteLine("Sending SMS from respective service");
        //}
        //public void SendEmailFromServiceChoosen()
        //{
        //    Console.WriteLine("Sending mail from respective service");
        //}
        //public void SendSMSForBothRecepientsAfterTransaction()
        //{
        //    Console.WriteLine("Sending SMS from respective service to receiver and sender");
        //}

    }
}

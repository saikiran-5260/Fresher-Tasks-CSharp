using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public interface IGpayPaymentServiceConfiguration
    {
        
        void SendSMSAfterTransaction(string number, string messagae);
        void SendEmailFromServiceChoosen(string message);
        void SendSMSForBothRecepientsAfterTransaction(string[] numbers, string messagae);
        void GetRecevingRecepient(string number);
    }
}

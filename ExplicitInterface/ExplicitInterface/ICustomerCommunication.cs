using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public interface ICustomerCommunication
    {
        void SendSMSAfterTransaction();
        void SendEmailFromServiceChoosen();
        void SendSMSForBothRecepientsAfterTransaction();
        void GetRecevingRecepient();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public interface ICardPaymet
    {
        void CardPayment();
        void SendSMSAfterTransaction();
        void SendEmailFromServiceChoosen();
        void SendSMSForBothRecepientsAfterTransaction();
    }
}

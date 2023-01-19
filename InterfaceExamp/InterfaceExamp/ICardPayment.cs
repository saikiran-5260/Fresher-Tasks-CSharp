using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public interface ICardPayment
    {
        void CardPayment();
        void SendOtpForTransaction();
        void SendSmsNotificationAfterPayment(string number,string message);
        void SendMailAfterTransaction(string message);
    }
}

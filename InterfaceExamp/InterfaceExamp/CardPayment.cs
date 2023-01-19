using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public class CardPayment
    {
        ICardPayment card;
        public CardPayment(ICardPayment c)
        {
            card= c;
        }
        public void Transfer()
        {
            Console.WriteLine("Transfering money using card");
            card.CardPayment();
            card.SendOtpForTransaction();
            card.SendMailAfterTransaction("The transfer has been taken place");
            card.SendSmsNotificationAfterPayment("8830238023", "Transaction is successful and balance");
        }
    }
}

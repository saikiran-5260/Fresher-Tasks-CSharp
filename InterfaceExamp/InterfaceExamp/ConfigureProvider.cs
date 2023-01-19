using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public class ConfigureProvider
    {
        public static IGpayPaymentServiceConfiguration GetCommunicationProvider()
        {
            return new RecepientCommunication__okhdfc();
        }
        public static ICardPayment GetPaymentProvider()
        {
            return new ICICI();
        }
    }
}

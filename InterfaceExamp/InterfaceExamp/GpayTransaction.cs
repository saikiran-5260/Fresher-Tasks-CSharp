using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamp
{
    public class GpayTransaction
    {
        IGpayPaymentServiceConfiguration _gpay;
        public GpayTransaction(IGpayPaymentServiceConfiguration gpay )
        {
            _gpay= gpay;
        }
        public void Transfer()
        {
            Console.WriteLine("Transfering money to the recepient via various UPI");
            _gpay.GetRecevingRecepient("9998887776");
            _gpay.SendEmailFromServiceChoosen("Sending email from so and so service");
        }
    }
}

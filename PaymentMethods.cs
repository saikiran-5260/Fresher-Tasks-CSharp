
using System;
namespace PaymentOptionsOverLoading
{
    public class PaymentMethods
    {
        public NetBanking nb;
        public COD c;
        public CreditCard cc;
        public DebitCard dc;
        public NetBanking PaymentMethod()
        {
            nb = new NetBanking();
            Console.Write("Please enter UserId: ");
            nb.UserId = Console.ReadLine();
            Console.Write("Please enter password: ");
            nb.Password = Console.ReadLine();
            Console.Write(nb.UserId + " " + nb.Password);
            Console.WriteLine("\n");
            
            return nb;
        }
        public COD PaymentMethod(NetBanking nb)
        {
            c= new COD();
            c.desc = "90% population is choosing online payment if you change your mind please folow below procedure";
            Console.WriteLine(c.desc);
            Console.WriteLine("\n");
            return c;

        }
        public CreditCard PaymentMethod(NetBanking nb, COD c)
        {
            cc = new CreditCard();
            Console.Write("Please enter cardNum: ");
            cc.cardNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter cardName: ");
            cc.cardName = Console.ReadLine();

            Console.Write("Please enter expiry Month: ");
            cc.expiryMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter expiry Year: ");
            cc.expiryYear = int.Parse(Console.ReadLine());

            Console.Write("Please enter CVV: ");
            cc.cvv = int.Parse(Console.ReadLine());
            Console.WriteLine(cc.cardNum + "," + cc.cardName + "," + cc.expiryMonth + "," + cc.expiryYear + "," + cc.cvv);
            Console.WriteLine("\n");
            return cc;

        }
        public DebitCard PaymentMethod(NetBanking nb, COD c,CreditCard cc)
        {
            dc = new DebitCard();
            Console.Write("Please enter cardNum: ");
            dc.cardNum = int.Parse(Console.ReadLine());

            Console.Write("Please enter cardName: ");
            dc.cardName = Console.ReadLine();

            Console.Write("Please enter expiry Month: ");
            dc.expiryMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter expiry year: ");
            dc.expiryYear = int.Parse(Console.ReadLine());

            Console.Write("Please enter CVV: ");
            dc.cvv = int.Parse(Console.ReadLine());

            Console.WriteLine(dc.cardNum + "," + dc.cardName+"," + dc.expiryMonth + "," + dc.expiryYear + "," + dc.cvv);
            Console.WriteLine("\n");
            return dc;

        }
    }
    public class NetBanking
    {
        public string UserId { get; set; }
        public string Password { get; set; }

    }
    public class COD
    {
        public string desc { get; set; }

    }
    public class CreditCard
    {
        public double cardNum { get; set; }    
        public int expiryMonth { get; set; }
        public int expiryYear { get; set; }
        public string cardName { get; set; }
        public int cvv { get; set; }

    }
    public class DebitCard
    {
        public int cardNum { get; set; }
        public int expiryMonth { get; set; }
        public int expiryYear { get; set; }
        public string cardName { get; set; }
        public int cvv { get; set; }

    }
}

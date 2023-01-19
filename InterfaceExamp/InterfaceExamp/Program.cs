

using InterfaceExamp;

IGpayPaymentServiceConfiguration Gpay = ConfigureProvider.GetCommunicationProvider();
ICardPayment Card = ConfigureProvider.GetPaymentProvider();

GpayTransaction gpayTransaction = new GpayTransaction(Gpay);
gpayTransaction.Transfer();

Console.WriteLine("\n");

CardPayment cp = new CardPayment(Card);
cp.Transfer();

using ExplicitInterface;

ExplicitInterfaceImplementation eii = new();

((ICustomerCommunication)eii).GetRecevingRecepient();
((ICustomerCommunication)eii).SendSMSAfterTransaction();
((ICustomerCommunication)eii).SendSMSForBothRecepientsAfterTransaction();
((ICustomerCommunication)eii).SendEmailFromServiceChoosen();
Console.WriteLine("\n");
((ICardPaymet)eii).CardPayment();
((ICardPaymet)eii).SendSMSAfterTransaction();
((ICardPaymet)eii).SendSMSForBothRecepientsAfterTransaction();
((ICardPaymet)eii).SendEmailFromServiceChoosen();


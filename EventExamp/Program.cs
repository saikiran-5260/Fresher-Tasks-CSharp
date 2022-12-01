using ClassLibrary1;
using EventExample;

SubscriberClass subscriber = new SubscriberClass();

Publisher publisher = new Publisher();

publisher.myEvent += subscriber.ADD;

publisher.RaiseEvent(10, 20);

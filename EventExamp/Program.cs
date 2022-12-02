using ClassLibrary1;
using EventExample;

//SubscriberClass subscriber = new SubscriberClass();

Publisher publisher = new Publisher();

//publisher.myEvent += subscriber.ADD;

//publisher.RaiseEvent(10, 20);
//publisher.RaiseEvent(5, 9);
//publisher.RaiseEvent(6, 4);

//publisher.myEvent += delegate (int a, int b) // Anonymous method  both methods helps in avoiding subscribe class or creating new class
//publisher.myEvent += ( a,  b) => //Lambda Expression( => )
//{
//    int c = a + b;
//    Console.WriteLine(c);
//    return c;
//};

//publisher.myEvent += (a) => /*a+b;*/ // for action delegate
//{
//    int c = a + b;
//    Console.WriteLine(c);

//};

publisher.myEvent += (a) => // Predicate delegate function
{
    return a >= 0;
};

//publisher.RaiseEvent(10, 20);
//publisher.RaiseEvent(5, 9);
//publisher.RaiseEvent(6, 4);


Console.WriteLine(publisher.RaiseEvent(10));
Console.WriteLine(publisher.RaiseEvent(-5));
Console.WriteLine(publisher.RaiseEvent(-6));



//Console.WriteLine(publisher.RaiseEvent(10, 20));
//Console.WriteLine(publisher.RaiseEvent(5, 9));
//Console.WriteLine(publisher.RaiseEvent(6, 4));

//publisher.RaiseEvent(10,20);
//publisher.RaiseEvent(5, 9);
//publisher.RaiseEvent(6, 4);

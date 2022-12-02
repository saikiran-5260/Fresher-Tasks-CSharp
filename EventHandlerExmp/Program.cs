using ClassLibrary1;


class Program
{

    static void Main()
    {
        Program p = new Program();  

        p.doWork();
    }
    public void doWork()
    {
        Publisher pub = new Publisher();

        pub.myEvent += (sender, e) =>
        {
            int c = e.a + e.b;
            Console.WriteLine(c);
        };


        pub.RaiseEvent(this, 10, 50);
        pub.RaiseEvent(this, 6, 4);
        pub.RaiseEvent(this, 10, 20);
    }
}







using System;

namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person() { NoOfChildren = 2 };
            Person p2 = new Person() { NoOfChildren = null };
            Person p3 = new Person() { NoOfChildren = null };
            Person p4 = new Person() { NoOfChildren = 5 };

            Console.WriteLine(p1.NoOfChildren); 

            if (p2.NoOfChildren.HasValue)  // HasValue is false if field value is null
            {
                Console.WriteLine(p2.NoOfChildren);
            }
            else
            {
                Console.WriteLine("null");
            }

            Console.WriteLine(p3.NoOfChildren ?? 0); //null coalescing

            Console.WriteLine(p4?.NoOfChildren); // null propagation
        }
    }
}
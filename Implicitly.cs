
// Implicitly type variable with keyword "var"

using namespace1.namespace2.namespace3;

namespace namespace1
{
    namespace namespace2
    {
        namespace namespace3
        {
            public class ImplicitlyTypeConvertion
            {
                public int userName { set; get; }
            }
        }
    }
}


class User
{
    static void Main()
    {
        namespace1.namespace2.namespace3.ImplicitlyTypeConvertion p = new namespace1.namespace2.namespace3.ImplicitlyTypeConvertion();
        Console.WriteLine(p.GetType());

        // Instead of above statement this helps in deciding the type of reference variable without declaring nested namespaces
        var p1 = new namespace1.namespace2.namespace3.ImplicitlyTypeConvertion();
        Console.WriteLine(p1.GetType());
    }
}
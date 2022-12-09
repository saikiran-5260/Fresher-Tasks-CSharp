
namespace NamedParameters1
{
    public class OptionalParameterClass
    {
        public OptionalParameterClass(double radius,double pi = 3.14)
        {
            Console.WriteLine("Area of circle is pi*r^2: {0}", pi*radius*radius);
        }
    }
}

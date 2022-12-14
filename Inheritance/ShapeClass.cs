
using System.Threading.Tasks;

namespace InheritanceExmp
{
    public class ShapeClass
    {
        public static int a, b;
    }
    public class Rectangle: ShapeClass 
    {
        int x = 0;
        public void AreaOfRectangele( )
        {
            Console.WriteLine("Area of Rectangel: {0}", a * b);
        }
    }
    public class Square : ShapeClass
    {
        public void AreaOfSquare()
        {
            Console.WriteLine("Area of Square: {0}", (a * a));
        }
    }
    public class Circle : ShapeClass 
    {
        public void AreaOfCircle()
        {
            Console.WriteLine("Area of circle: {0}", (3.14 * a * a));
        }
    }

}

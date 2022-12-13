
namespace TaskMethodOverLoading
{
    public class AreaExmp
    {
        public void Area(double l)
        {
            Console.WriteLine("Area of square: " + (l * l));
        }
      
        public void Area(double w, int l)
        {
            Console.WriteLine("Area of rectangle: "+ (w*l));
        }
        public void Area(int h, int b)
        {
            Console.WriteLine("Area of triangle: " + ((b * h) / 2));

        }


    public class PerimeterExmp
        {
            public void Perimeter(int a)
            {
                Console.WriteLine("\nPerimter of square: " + (4 * a));
            }
            public void Perimeter(int l, int w)
            {
                Console.WriteLine("Perimter of rectangle: " + 2 * (l * w));
            }
            public void Perimeter(int a, int b, int c)
            {
                Console.WriteLine("Perimter of triangle : " + (a + b + c));

            }

        }
       
    }
}

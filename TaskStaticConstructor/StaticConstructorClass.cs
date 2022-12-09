
namespace StaticConstructor
{
    internal class StaticConstructorClass
    {
        public static string dishName = "";
        public static string description = "";
        public int dishPrice;

        static StaticConstructorClass()
        {
            Console.WriteLine("Static Constructor is called: Restaurant Menu");
            dishName = "Biriyani";
            description = "This dish is famous all over the world and its origin is from india and famous" +
                " in hyderabad";

        }

        public void DiaplayDetails()
        {
            Console.WriteLine("Dish Name: {0}  Dish Price: {1}   Dish Description: {2}", dishName, dishPrice, description);
        }

        static void DemoDisplay()
        {
            Console.WriteLine("Static Method is called and method has more priority than constructor");
            dishName = "Mutton Biriyani";
        }

    }
}

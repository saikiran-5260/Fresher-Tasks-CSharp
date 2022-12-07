
namespace PolymorphismExmp
{
    public class MethodOverLoading
    {
        int bikePrice;
        string bikeName;
        int onRoadPrice;

        public void DisplayDetails()
        {
            Console.WriteLine("Example of static/compile/early bind polymorphism: \n");
        }
        public void DisplayDetails(int bikePrice)
        {

            Console.WriteLine("Bike price: {0}",bikePrice);
        }
        public void DisplayDetails(int bikePrice,string bikeName)
        {
            Console.WriteLine("Bike price: {0} and Bike name: {1}", bikePrice,bikeName);
        }
        public void DisplayDetails(int bikePrice, string bikeName,int onRoadPrice)
        {
            Console.WriteLine("Bike price: {0} and Bike name: {1} and on road price:{2}", bikePrice, bikeName,onRoadPrice);
        }

        

    }
    public class ChildClass: MethodOverLoading
    {
        int toolsCost;

        public void DisplayDetails(int bikePrice, string bikeName, int onRoadPrice, int toolsCost)
        {
            Console.WriteLine("Bike price: {0} and Bike name: {1} and on road price:{2} and toolsCost: {3}", bikePrice, bikeName, onRoadPrice, toolsCost);

        }
    }
}

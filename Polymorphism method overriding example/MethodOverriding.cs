

using System.Runtime.InteropServices;

namespace PolymorphismMethodOverriding
{
    public class MethodOverriding
    {
        int bikePrice;
        string bikeName = "";
        public int onRoadPrice;
        public string city = "";
        int roadTax;

        public virtual void DisplayDetails(int bikePrice,string bikeName,int roadTax, string city)
        {
            Console.WriteLine("Bike Price: {0} and Bike Name: {1} and RoadTax: {2} in city {3}", bikePrice,bikeName, roadTax, city);
            onRoadPrice = bikePrice + roadTax;
            Console.WriteLine("OnRoad of this bike is: {0}",onRoadPrice);
        }
    }

    public class ChildClass : MethodOverriding
    {
        public override void DisplayDetails(int bikePrice, string bikeName, int roadTax, string city)
        {
            
            Console.WriteLine("Bike Price: {0} and Bike Name: {1} and RoadTax: {2} in city {3}", bikePrice, bikeName, roadTax, city);
            onRoadPrice = bikePrice + roadTax;
            Console.WriteLine("OnRoad of this bike is: {0}", onRoadPrice);
            Console.WriteLine("Method Overriding is acheived:");
        }
    }
}

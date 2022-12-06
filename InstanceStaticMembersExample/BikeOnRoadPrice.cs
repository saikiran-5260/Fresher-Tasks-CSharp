using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStaticMembersExmp
{
    public class BikeOnRoadPrice
    {
        public int onRoadPrice;
        public string bikeModelName;
        public static int bikePrice;

        public BikeOnRoadPrice(int onRoadCost, string bikeModel)
        {
            onRoadPrice = onRoadCost;
            bikeModelName= bikeModel;
        }

        public void DisplayDetials()
        {
            Console.WriteLine("Choose City: ");
            Console.WriteLine("Hyderabad");
            Console.WriteLine("Banglore");
            Console.WriteLine("Chenni");
            Console.WriteLine("Mumbai");
            Console.WriteLine("Pune");

            string chooseCity;
            Console.Write("Please enter the city:");
            chooseCity = Console.ReadLine();    

            switch(chooseCity)
            {
                case "Hyderabad": Console.WriteLine("\nBike price: {0}\nBike Name: {1} \nOn road price: {2}", onRoadPrice, bikeModelName, bikePrice + onRoadPrice);break;
                case "Banglore": Console.WriteLine("\nBike price: {0}\nBike Name: {1} \nOn road price: {2}", onRoadPrice, bikeModelName, bikePrice + onRoadPrice+2000); break;
                case "Chenni": Console.WriteLine("\nBike price: {0}\nBike Name: {1} \nOn road price: {2}", onRoadPrice, bikeModelName, bikePrice + onRoadPrice+3000); break;
                case "Mumbai": Console.WriteLine("\nBike price: {0}\nBike Name: {1} \nOn road price: {2}", onRoadPrice, bikeModelName, bikePrice + onRoadPrice+4000); break;
                case "Pune": Console.WriteLine("\nBike price: {0}\nBike Name: {1} \nOn road price: {2}", onRoadPrice, bikeModelName, bikePrice + onRoadPrice+5000); break;
                default: Console.WriteLine("\nCity which is provided does not exist in the list"); break;
            }


            
        }
    }
}

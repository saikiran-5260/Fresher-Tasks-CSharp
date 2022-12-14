using System.Collections;
using CollectionOfObj;


List<Product> p = new List<Product>();

string choice = "";
do
{
    Product product = new Product();
    Console.Write("Enter product id: ");
    product.productID = int.Parse(Console.ReadLine());

    Console.Write("Enter product name: ");
    product.productName = Console.ReadLine();

    Console.Write("Price of product: ");
    product.price = int.Parse(Console.ReadLine());

    Console.Write("Please enter date of manufacture in yyyy-mm-dd: ");
    product.dom = DateTime.Parse(Console.ReadLine());

    p.Add(product);

    Console.Write("Please enter your choice Yes/No : ");
    choice = Console.ReadLine();
    Console.WriteLine("\n");

} while (choice != "No" && choice != "no" && choice != "n" && choice != "NO" && choice != "nO");


foreach (Product item in p)
{
    Console.WriteLine(item.productID + " " + item.productName + " " + item.price + " " + item.dom.ToShortDateString());
}
class Sample
{
    static void Main()
    {
        Product product1, product2;
        product1 = new Product();
        product2 = new Product();
        
        product1.productId = 1;
        product1.productName = "Samsung";
        product1.productDescription = "Mobile";
        product1.price = 100000;
        product1.quantity = 1;
        product1.Discount = 20;

       

        product1.CalulateDiscount();
        System.Console.WriteLine(product1.priceAfterDiscount);
        System.Console.WriteLine(product1.productId);
        System.Console.WriteLine(product1.productName);
        System.Console.WriteLine(product1.productDescription);
        System.Console.WriteLine(product1.price);
        System.Console.WriteLine(product1.quantity);
        System.Console.WriteLine(product1.Discount);

        product2.productId = 2;
        product2.productName = "HP";
        product2.productDescription = "LAPTOP";
        product2.price = 150000;
        product2.quantity = 2;
        product2.Discount = 10;

        product2.CalulateDiscount();
        
        System.Console.WriteLine("\n");
        System.Console.WriteLine(product2.productId);
        System.Console.WriteLine(product2.productName);
        System.Console.WriteLine(product2.productDescription);
        System.Console.WriteLine(product2.price);
        System.Console.WriteLine(product2.quantity);
        System.Console.WriteLine(product2.Discount);

        if (product2.quantity == 2)
        {
            System.Console.WriteLine((product2.priceAfterDiscount) * 2);
        }
        

        System.Console.ReadKey();

    }
}
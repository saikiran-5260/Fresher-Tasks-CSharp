using System.Diagnostics;

public class Product
{
    public int productId;
    public string productName;
    public string productDescription;
    public int price;
    public int quantity;
    public double Discount;
    public int priceAfterDiscount;
    

    public void CalulateDiscount()

    {
         //double DiscountPercent = Discount /100;
        int discountPrice = (int) (price * (Discount/100));
        priceAfterDiscount = price - discountPrice;
    }
}


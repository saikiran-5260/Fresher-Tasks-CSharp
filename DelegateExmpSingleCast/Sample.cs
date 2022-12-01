namespace ClassLibrary1
{
    public class Sample
    {
        public double DiscountCal(double mrp, double discountPrice)
        {
            double discountPercentage = (mrp - discountPrice)/mrp * 100;
            return discountPercentage;
        }
    }
}
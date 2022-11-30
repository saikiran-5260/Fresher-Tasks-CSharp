using System;
using ClassLibrary1;

namespace ExtentionMethodExmp
{
    public static class ProductExtention
    {
        public static double GetDiscount(this Product product)
        {
            return product.productCost * product.productDiscount / 100;
        }
    }
}

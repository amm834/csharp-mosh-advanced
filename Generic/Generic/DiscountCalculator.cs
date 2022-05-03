namespace Generic;

public class DiscountCalculator<TProduct> where TProduct : Product, new()
{
    public void DoSomething()
    {
        var product = new TProduct();
    }

    public int CalculateDicount(TProduct product)
    {
        return product.Price;
    }
}
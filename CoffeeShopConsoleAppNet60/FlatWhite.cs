namespace CoffeeShopConsoleAppNet60;

public class FlatWhite(int discount) : Coffee(discount)
{
    public override int Price()
    {
        if (discount > 5)
        {
            throw new Exception("You cannot have a price of more than 5 kroner.");
        }
        
        return 30 - Discount;
    }
        
    public override string Strength()
    {
        return "Medium";
    }

    public override string ToString()
    {
        return $"Price: {Price()}, Strength: {Strength()}";
    }
}
namespace CoffeeShopConsoleAppNet60;

public abstract class Coffee(int discount)
{
    public int Discount { get; private set; } = discount;

    public virtual int Price()
    {
        if (discount > 5)
        {
            throw new Exception("You cannot have a price of more than 5 kroner.");
        }
        
        return 20 - Discount;
    }

    public abstract string Strength();
    
    public override string ToString()
    {
        return $"Price: {Price()}";
    }
}
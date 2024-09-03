namespace CoffeeShopConsoleAppNet60;

public class BlackCoffee(int discount) : Coffee(discount)
{
    public override string Strength()
    {
        return "Strong";
    }

    public BlackCoffee(): this(0)
    {
        
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, Strength: {Strength()}";
    }
}
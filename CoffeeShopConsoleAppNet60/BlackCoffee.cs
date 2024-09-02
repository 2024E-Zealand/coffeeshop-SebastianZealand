namespace CoffeeShopConsoleAppNet60;

public class BlackCoffee(int discount) : Coffee(discount)
{
    public override string Strength()
    {
        return "Strong";
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, Strength: {Strength()}";
    }
}
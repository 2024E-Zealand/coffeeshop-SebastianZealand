namespace CoffeeShopConsoleAppNet60;

public class BlackCoffee : Coffee
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
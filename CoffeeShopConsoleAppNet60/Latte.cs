namespace CoffeeShopConsoleAppNet60;

public class Latte : Coffee
{
    public int Price()
    {
        return 40;
    }

    public override string Strength()
    {
        return "Weak";
    }
}
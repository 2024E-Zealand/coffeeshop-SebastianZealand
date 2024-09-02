namespace CoffeeShopConsoleAppNet60;

public class Cortado : Coffee
{
    public int Price()
    {
        return 25;
    }

    public override string Strength()
    {
        return "Medium";
    }
}
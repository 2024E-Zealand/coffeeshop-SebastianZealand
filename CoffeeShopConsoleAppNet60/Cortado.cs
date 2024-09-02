namespace CoffeeShopConsoleAppNet60;

public class Cortado : Coffee, IMilk
{
    public int Price()
    {
        return 25;
    }

    public override string Strength()
    {
        return "Medium";
    }

    public int MlMilk()
    {
        return 40;
    }

    public override string ToString()
    {
        return $"Price: {Price()}, Strength is {Strength()}";
    }
}
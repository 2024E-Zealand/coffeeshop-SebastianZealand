namespace CoffeeShopConsoleAppNet60;

public class Latte : Coffee, IMilk
{
    public int Price()
    {
        return 40;
    }

    public override string Strength()
    {
        return "Weak";
    }

    public int MlMilk()
    {
        return 200;
    }

    public override string ToString()
    {
        return $"Price: {Price()}, Strength: {Strength()}";
    }
}
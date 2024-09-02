namespace CoffeeShopConsoleAppNet60;

public abstract class Coffee
{
    public int Price()
    {
        return 20;
    }

    public abstract string Strength();

    public override string ToString()
    {
        return $"Price: {Price()}";
    }
}
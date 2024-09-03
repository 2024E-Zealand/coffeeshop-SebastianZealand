namespace CoffeeShopConsoleAppNet60;

public class Cortado(int discount) : Coffee(discount), IMilk
{
    public override int Price()
    {
        if (discount > 5)
        {
            throw new Exception("You cannot have a price of more than 5 kroner.");
        }
        
        return 25 - discount;
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
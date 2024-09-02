namespace CoffeeShopConsoleAppNet60;

public class Latte(int discount) : Coffee(discount), IMilk
{
    public int Price()
    {
        if (discount > 5)
        {
            throw new Exception("You cannot have a price of more than 5 kroner.");
        }
        
        return 40 - discount;
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
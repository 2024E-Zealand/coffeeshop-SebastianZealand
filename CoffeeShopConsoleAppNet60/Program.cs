namespace CoffeeShopConsoleAppNet60;

class Program
{
    static void Main(string[] args)
    {
        BlackCoffee blackCoffee = new BlackCoffee(0);
        Latte latte = new Latte(0);
        Cortado cortado = new Cortado(0);
        
        List<Coffee> coffees = new List<Coffee>();
        
        coffees.Add(blackCoffee);
        coffees.Add(latte);
        coffees.Add(cortado);

        foreach (var c in coffees)
        {
            Console.WriteLine(c);
        }
        
        // Create list of coffee containing milk, so list of classes implementing the IMilk
        List<IMilk> coffeeWithMilk = new List<IMilk>();
        
        coffeeWithMilk.Add(latte);
        coffeeWithMilk.Add(cortado);
        
    }
}
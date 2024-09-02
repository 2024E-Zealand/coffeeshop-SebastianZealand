namespace CoffeeShopConsoleAppNet60;

class Program
{
    static void Main(string[] args)
    {
        BlackCoffee blackCoffee = new BlackCoffee();
        Latte latte = new Latte();
        Cortado cortado = new Cortado();

        List<Coffee> coffees = new List<Coffee>();
        
        coffees.Add(blackCoffee);
        coffees.Add(latte);
        coffees.Add(cortado);

        foreach (var c in coffees)
        {
            Console.WriteLine(c);
        }
    }
}
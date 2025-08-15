using patterns_gof_factory_method_v2.ConcreteCreator;
using patterns_gof_factory_method_v2.Product;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha a pizza: ");
        Console.WriteLine("(1)Calabreza (2)Mussarela (3)Portuguesa (4)Quatro Queijos");
        var pizzaEscolhida = Convert.ToInt32(Console.ReadLine());
        try
        {
            PizzaFactory pizzaFactory = new PizzaFactory();
            Pizza pizza = pizzaFactory.CriarPizza(pizzaEscolhida);
            Console.WriteLine(pizza.Nome);
            foreach (var ingrediente in pizza.Ingredientes)
                Console.WriteLine(ingrediente);
                

            Console.WriteLine("\nPizza concluída com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        Console.ReadLine();
    }
}
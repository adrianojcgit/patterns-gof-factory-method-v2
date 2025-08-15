using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2._ConcreteProduct
{
    public class PizzaCalabreza : Pizza
    {
        private readonly string _nomePizza;
        public PizzaCalabreza()
        {
            _nomePizza = "Pizza Calabreza";
            Ingredientes.Add("Fatias de calabreza especial.");
            Ingredientes.Add("Queijo parmessão italiano tradicional.");
        }
        public override string Nome => _nomePizza;
    }
}
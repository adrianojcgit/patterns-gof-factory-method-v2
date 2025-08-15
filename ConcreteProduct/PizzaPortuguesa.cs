using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2._ConcreteProduct
{
    //ConcreteProduct
    public class PizzaPortuguesa : Pizza
    {
        private readonly string _nomePizza;
        public PizzaPortuguesa()
        {
            _nomePizza = "Pizza Portuguesa";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Ervilhas");
            Ingredientes.Add("Cebola");
            Ingredientes.Add("Ovos cozidos");
        }
        public override string Nome => _nomePizza;
    }
}
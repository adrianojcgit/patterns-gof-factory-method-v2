using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2._ConcreteProduct
{
    //ConcreteProduct
    public class PizzaQuatroQueijos : Pizza
    {
        private readonly string _nomePizza;
        public PizzaQuatroQueijos()
        {
            _nomePizza = "Pizza Quatro Queijos";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Queijo Gorgonzola");
            Ingredientes.Add("Queijo Brie");
            Ingredientes.Add("Queijo Provolone");
        }        
        public override string Nome => _nomePizza;
    }
}
using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaMussarela : Pizza
    {
        private readonly string _nomePizza;
        public PizzaMussarela()
        {
            _nomePizza = "Pizza Mussarela";
            Ingredientes.Add("Queijo parmesão ralado.");
            Ingredientes.Add("Molho de tomate e azeitonas.");
        }
        public override string Nome => _nomePizza;
    }
}
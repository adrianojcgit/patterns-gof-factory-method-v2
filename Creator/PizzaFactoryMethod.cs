using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2.Creator
{
    //Creator
    public abstract class PizzaFactoryMethod
    {
        public abstract Pizza CriarPizza(int tipo);
    }
}
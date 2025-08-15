using patterns_gof_factory_method_v2._ConcreteProduct;
using patterns_gof_factory_method_v2.ConcreteProduct;
using patterns_gof_factory_method_v2.Creator;
using patterns_gof_factory_method_v2.Product;

namespace patterns_gof_factory_method_v2.ConcreteCreator
{
    public class PizzaFactory : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(int tipo)
        {
            var factory = PizzaFactories[tipo];
            return factory();
        }

        public static Dictionary<int, Func<Pizza>> PizzaFactories = new Dictionary<int, Func<Pizza>>
        {
            { 1, ()=>new PizzaCalabreza() },
            { 2, ()=>new PizzaMussarela() },
            { 3, ()=>new PizzaPortuguesa() },
            { 4, ()=>new PizzaQuatroQueijos() },
        };
    }
}
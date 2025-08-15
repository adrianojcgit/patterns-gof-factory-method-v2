using System.Collections;

namespace patterns_gof_factory_method_v2.Product
{
    //Product
    public abstract class Pizza
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}
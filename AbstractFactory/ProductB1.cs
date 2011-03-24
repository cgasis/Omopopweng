using System;
using System.Text;

namespace AbstractFactories
{
    /// <summary>
    /// the ProductB1 Class
    /// </summary>
    public class ProductB1 : AbstractProductB
    {
        public ProductB1() {}

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interracts with " + a.GetType().Name);
        }
    }
}

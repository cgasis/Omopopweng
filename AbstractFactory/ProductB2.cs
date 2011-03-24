using System;
using System.Text;

namespace AbstractFactories
{
    /// <summary>
    /// the ProductB2 class
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        public ProductB2 ( ) { }

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interracts with " + a.GetType().Name);
        }
    }
}

using System;
using System.Text;

namespace AbstractFactories
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public ConcreteFactory1 ( ) { }

        public override AbstractProductA CreateProductA ( )
        {
            return new ProductA1 ( );
        }

        public override AbstractProductB CreateProductB ( )
        {
            return new ProductB1 ( );
        }
    }
}

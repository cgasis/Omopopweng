using System;
using System.Text;

namespace AbstractFactories
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class  AbstractFactory
    {
       public abstract AbstractProductA CreateProductA();
       public abstract AbstractProductB CreateProductB();        
    }
}

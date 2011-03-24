using System;
using System.Text;

namespace AbstractFactories
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    public class Client
    {
        public     AbstractProductA    _abstractProductA;
        public     AbstractProductB    _abstractProductB;

        //Constructor
        public Client ( ) { }
        public Client ( AbstractFactory factory ) {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run ( ) { 
            _abstractProductB.Interact(_abstractProductA);
        }

    }
}

using ExamenPatterns.AbstractFactory.Product.ConcreteProduct;
using ExamenPatterns.Decorator.AbstractDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.Decorator.ConcreteDecorator
{
    public class PizzaWithSauce : PizzaDecorator
    {
        public static string Name => "Sauce";
        public PizzaWithSauce(Pizza pizza) : base(pizza)
        {
            name = Name;
        }
    }
}

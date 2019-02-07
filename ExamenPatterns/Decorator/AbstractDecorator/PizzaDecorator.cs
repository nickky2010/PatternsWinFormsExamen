using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using ExamenPatterns.AbstractFactory.Product.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.Decorator.AbstractDecorator
{
    public abstract class PizzaDecorator : AbstractPizza
    {
        protected Pizza pizza;
        protected new string name;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string ToString()
        {
            return pizza.ToString() + " with " + name;
        }
    }
}

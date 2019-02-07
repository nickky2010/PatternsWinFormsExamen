using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.AbstractFactory.Product.AbstractProduct
{
    public abstract class AbstractPizza
    {
        protected string name;
        protected PizzaType pizzaType;
        protected string composition;
        protected double ingredientWeight;

        public AbstractPizza()
        {
            this.name = "pizza";
        }
        public override string ToString()
        {
            return name;
        }
    }
}

using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.AbstractFactory.Product.ConcreteProduct
{
    public class Pizza : AbstractPizza
    {
        StringBuilder builder;
        public Pizza(PizzaType pizzaType, string composition, double ingredientWeight)
        {
            this.pizzaType = pizzaType;
            this.composition = composition;
            this.ingredientWeight = ingredientWeight;
            builder = new StringBuilder();
            builder.Append(pizzaType.ToString()).Append(" ").Append(name).Append(" with ").
                Append(composition).Append(" ").Append(ingredientWeight).Append(" gr.");
        }
        public override string ToString()
        {
            return builder.ToString();
        }
    }
}

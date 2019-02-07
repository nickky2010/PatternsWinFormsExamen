using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using ExamenPatterns.Decorator.AbstractDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.ChainOfResponsibility
{
    public interface IProducerHandler
    {
        IProducerHandler Successor { get; set; }
        uint IdOrder { get; set; }
        AbstractPizza CreatePizza(PizzaType pizzaType, string composition, double ingredientWeight, uint idOrder, string pizzaDecorators);
        AbstractBarbecue CreateBarbecue(string meatType, uint idOrder);
    }
}

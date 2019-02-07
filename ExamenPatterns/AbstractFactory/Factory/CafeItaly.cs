using ExamenPatterns.AbstractFactory.Factory.Interfaces;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using ExamenPatterns.AbstractFactory.Product.ConcreteProduct;
using ExamenPatterns.ChainOfResponsibility;
using ExamenPatterns.Decorator.AbstractDecorator;
using ExamenPatterns.Decorator.ConcreteDecorator;
using ExamenPatterns.Observer;
using ExamenPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExamenPatterns.AbstractFactory.Factory
{
    public class CafeItaly : AbstractCafe
    {
        public CafeItaly(IObservable market)
        {
            name = "Cafe Italy";
            market.RegisterObserver(this);
            priceInfo = market.GetInfo();
            priceCategory = 1.25;
            ListOfProducedBarbecueByTypeOfMeat = new List<string>();
            ListOfProducedPizzasByType = new List<PizzaType>();
            ListOfProducedPizzasByCompositions = new List<string>();
            ListOfProducedDecorator = new List<string>();
            ListOfProducedPizzasByIngredientWeight = new List<string>();
            listOrders = new List<string>();
            listCheck = new List<decimal>();
            ListOfProducedBarbecueByTypeOfMeat.Add("Pork");
            ListOfProducedPizzasByType.Add(PizzaType.Open);
            ListOfProducedPizzasByCompositions.Add("Chicken");
            ListOfProducedPizzasByCompositions.Add("Pepper");
            ListOfProducedPizzasByCompositions.Add("Mushrooms");
            ListOfProducedDecorator.Add("Sauce");
            ListOfProducedPizzasByIngredientWeight.Add("250");
            ListOfProducedPizzasByIngredientWeight.Add("500");
        }
    }
}

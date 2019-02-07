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

namespace ExamenPatterns.AbstractFactory.Factory
{
    public class CafeReadHead : AbstractCafe
    {
        public CafeReadHead(IObservable market)
        {
            name = "Cafe Read Head";
            market.RegisterObserver(this);
            priceInfo = market.GetInfo();
            priceCategory = 1.55;
            ListOfProducedBarbecueByTypeOfMeat = new List<string>();
            ListOfProducedPizzasByType = new List<PizzaType>();
            ListOfProducedPizzasByCompositions = new List<string>();
            ListOfProducedDecorator = new List<string>();
            ListOfProducedPizzasByIngredientWeight = new List<string>();
            listOrders = new List<string>();
            listCheck = new List<decimal>();
            ListOfProducedBarbecueByTypeOfMeat.Add("Mutton");
            ListOfProducedPizzasByType.Add(PizzaType.Closed);
            ListOfProducedPizzasByCompositions.Add("Seafood");
            ListOfProducedPizzasByCompositions.Add("Cheese");
            ListOfProducedDecorator.Add("Vegetables");
            ListOfProducedPizzasByIngredientWeight.Add("750");
            ListOfProducedPizzasByIngredientWeight.Add("1000");
        }
    }
}

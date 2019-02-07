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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.AbstractFactory.Factory.Interfaces
{
    public abstract class AbstractCafe: IObserver, IProducerHandler
    {
        protected string name;
        protected double priceCategory;
        protected PriceInfo priceInfo;
        public string Name => name;
        public double PriceCategory => priceCategory;
        public List<string> ListOfProducedBarbecueByTypeOfMeat { get; set; }
        public List<PizzaType> ListOfProducedPizzasByType { get; set; }
        public List<string> ListOfProducedPizzasByCompositions { get; set; }
        public List<string> ListOfProducedPizzasByIngredientWeight { get; set; }
        public IProducerHandler Successor { get; set; }
        public uint IdOrder { get; set; }
        public List<string> ListOfProducedDecorator { get; set; }
        protected List<string> listOrders;
        public List<string> ListOrders => listOrders;
        protected List<decimal> listCheck;
        public List<decimal> ListCheck => listCheck;
        public AbstractBarbecue CreateBarbecue(string meatType, uint idOrder)
        {
            AbstractBarbecue barbecue = null;
            if (ListOfProducedBarbecueByTypeOfMeat.Contains(meatType))
            {
                barbecue = new Barbecue(meatType);
                listOrders.Add(barbecue.ToString());
                listCheck.Add(CalculateOrderByBarbecue(meatType));
            }
            else if (Successor != null && Successor.IdOrder != idOrder)
            {
                barbecue = (Barbecue)Successor.CreateBarbecue(meatType, idOrder);
            }
            return barbecue;
        }

        public AbstractPizza CreatePizza(PizzaType pizzaType, string composition, double ingredientWeight,
    uint idOrder, string pizzaDecorators)
        {
            AbstractPizza pizza = null;
            if (ListOfProducedPizzasByType.Contains(pizzaType) &&
                ListOfProducedPizzasByCompositions.Contains(composition))
            {
                pizza = new Pizza(pizzaType, composition, ingredientWeight);
                if (ListOfProducedDecorator.Contains(pizzaDecorators) && pizzaDecorators == PizzaWithSauce.Name)
                    pizza = new PizzaWithSauce((Pizza)pizza);
                else if (ListOfProducedDecorator.Contains(pizzaDecorators) && pizzaDecorators == PizzaWithFlowersFromVegetables.Name)
                    pizza = new PizzaWithFlowersFromVegetables((Pizza)pizza);
                listOrders.Add(pizza.ToString());
                listCheck.Add(CalculateOrderByPizza(composition, ingredientWeight, pizzaDecorators));
            }
            else if (Successor != null && Successor.IdOrder != idOrder)
            {
                pizza = Successor.CreatePizza(pizzaType, composition, ingredientWeight, idOrder, pizzaDecorators);
            }
            return pizza;
        }
        protected decimal CalculateOrderByPizza(string composition, double ingredientWeight, string pizzaDecorators)
        {
            Type myType = Type.GetType(priceInfo.ToString(), false, true);
            decimal totalPrice = 0;
            foreach (MemberInfo property in myType.GetProperties())
            {
                if (property.Name == composition)
                {
                    decimal price = (decimal)(priceInfo.GetType().GetProperty(property.Name).GetValue(priceInfo, null));
                    totalPrice += (price*(decimal)(Convert.ToDouble(ingredientWeight)/1000))* (decimal)priceCategory;
                }
                else if (property.Name == pizzaDecorators)
                {
                    decimal price = (decimal)(priceInfo.GetType().GetProperty(property.Name).GetValue(priceInfo, null));
                    totalPrice += (price * (decimal)priceCategory);
                }
            }
            return totalPrice;
        }
        protected decimal CalculateOrderByBarbecue(string meatType)
        {
            Type myType = Type.GetType(priceInfo.ToString(), false, true);
            decimal totalPrice = 0;
            foreach (MemberInfo property in myType.GetProperties())
            {
                if (property.Name == meatType)
                {
                    decimal price = (decimal)(priceInfo.GetType().GetProperty(property.Name).GetValue(priceInfo, null));
                    totalPrice += price * (decimal)priceCategory;
                    return totalPrice;
                }
            }
            return totalPrice;
        }
        public void Update(PriceInfo priceInfo)
        {
            this.priceInfo = priceInfo;
        }
    }
}

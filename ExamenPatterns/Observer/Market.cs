using ExamenPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.Observer
{
    public class Market : IObservable
    {
        PriceInfo priceInfo;

        List<IObserver> observers;
        public Market()
        {
            observers = new List<IObserver>();
            priceInfo = new PriceInfo();
            MarketChange();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(priceInfo);
            }
        }
        public PriceInfo GetInfo()
        {
            return priceInfo;
        }

        public void MarketChange()
        {
            Random rnd = new Random();
            priceInfo.Mutton = rnd.Next(20, 40);
            priceInfo.Seafood = rnd.Next(20, 30);
            priceInfo.Cheese = rnd.Next(8, 15);
            priceInfo.Vegetables = rnd.Next(5, 10);
            priceInfo.Pork = rnd.Next(15, 30);
            priceInfo.Chicken = rnd.Next(10, 25);
            priceInfo.Pepper = rnd.Next(5, 10);
            priceInfo.Mushrooms = rnd.Next(8, 17);
            priceInfo.Sauce = rnd.Next(4, 10);
            NotifyObservers();
        }
    }
}

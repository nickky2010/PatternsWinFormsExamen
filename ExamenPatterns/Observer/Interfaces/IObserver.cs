using ExamenPatterns.AbstractFactory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.Observer.Interfaces
{
    public interface IObserver
    {
        void Update(PriceInfo priceInfo);
    }
}

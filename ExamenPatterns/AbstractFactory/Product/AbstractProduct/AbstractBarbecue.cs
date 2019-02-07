using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.AbstractFactory.Product.AbstractProduct
{
    public abstract class AbstractBarbecue
    {
        protected string name;
        protected string meatType;

        protected AbstractBarbecue()
        {
            this.name = "barbecue";
        }
        public override string ToString()
        {
            return name;
        }
    }
}

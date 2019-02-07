using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatterns.AbstractFactory.Product.ConcreteProduct
{
    public class Barbecue:AbstractBarbecue
    {
        StringBuilder builder;

        public Barbecue(string meatType)
        {
            this.meatType = meatType;
            builder = new StringBuilder();
            builder.Append(meatType).Append(" ").Append(name);
        }
        public override string ToString()
        {
            return builder.ToString();
        }
    }
}

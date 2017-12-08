using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Decorator;

namespace DecoratorConcrete
{
    public class PremiumUpgrade : HouseDecorator
    {
        public PremiumUpgrade(IHouse house) : base(house)
        {
            this.Description = "Upgraded to premium grade inclusions";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ExtraCost();
        }

        public override double ExtraCost()
        {
            return 8499.00;
        }
    }
}
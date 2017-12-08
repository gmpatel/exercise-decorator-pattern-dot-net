using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Decorator;

namespace DecoratorConcrete
{
    public class PlatinumUpgrade : HouseDecorator
    {
        public PlatinumUpgrade(IHouse house) : base(house)
        {
            this.Description = "Upgraded to platinum grade inclusions";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ExtraCost();
        }

        public override double ExtraCost()
        {
            return 15999.00;
        }
    }
}
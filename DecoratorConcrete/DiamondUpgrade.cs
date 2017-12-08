using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Decorator;

namespace DecoratorConcrete
{
    public class DiamondUpgrade : HouseDecorator
    {
        public DiamondUpgrade(IHouse house) : base(house)
        {
            this.Description = "Upgraded to diamond grade inclusions";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ExtraCost();
        }

        public override double ExtraCost()
        {
            return 28999.00;
        }
    }
}
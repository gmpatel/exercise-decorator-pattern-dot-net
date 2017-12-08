using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Decorator;

namespace DecoratorConcrete
{
    public class StructureOnlyNoBasics : HouseDecorator
    {
        public StructureOnlyNoBasics(IHouse house) : base(house)
        {
            this.Description = "Degraded to structure only house; no basics will be provided even";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + ExtraCost();
        }
        
        public override double ExtraCost()
        {
            return -54999.00;
        }
    }
}
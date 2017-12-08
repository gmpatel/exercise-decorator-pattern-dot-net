using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace Decorator
{
    public abstract class HouseDecorator : IHouse
    {
        private readonly IHouse house;

        protected HouseDecorator(IHouse house)
        {
            this.house = house;
        }

        public HouseTypes HouseType
        {
            get { return house.HouseType; }
        }
        
        public string Builder
        {
            get { return house.Builder; }
        }

        public string Model
        {
            get { return house.Model; }
        }

        public double BasePrice
        {
            get { return house.BasePrice; }
        }

        public string Description
        {
            get { return house.Description; }
            set { house.Description = value; }
        }


        public virtual double ExtraCost()
        {
            return 0;
        }

        public virtual double GetPrice()
        {
            return house.BasePrice;
        }
    }
}
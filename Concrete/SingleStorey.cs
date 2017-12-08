using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace CoreConcrete
{
    public class SingleStorey : IHouse
    {
        public SingleStorey(string builder, string model, double basePrice)
        {
            Builder = builder;
            Model = model;
            BasePrice = basePrice;
            Description = "Basic Home";
        }

        public HouseTypes HouseType { get { return HouseTypes.SingleStorey; } }

        public string Builder { get; private set; }

        public string Model { get; private set; }

        public double BasePrice { get; private set; }

        public string Description { get; set; }


        public double GetPrice()
        {
            return BasePrice;
        }
    }
}
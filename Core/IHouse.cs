using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public interface IHouse
    {
        HouseTypes HouseType { get; }
        string Builder { get; }
        string Model { get; }
        double BasePrice { get; }
        string Description { get; set; }

        double GetPrice();
    }
}
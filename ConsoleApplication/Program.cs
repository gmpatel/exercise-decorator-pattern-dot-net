using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using CoreConcrete;
using DecoratorConcrete;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var ssh1 = new SingleStorey("McDonald Jones Homes", "Monte Carlo - The Beach Hous", 229688.00);
            var ssh2 = new SingleStorey("McDonald Jones Homes", "Pinnacle - Seaside Retreat", 249736.00);

            var dsh1 = new DoubleStorey("McDonald Jones Homes", "Monte Carlo - The Beach Hous", 310323.00);
            var dsh2 = new DoubleStorey("McDonald Jones Homes", "Pinnacle - Seaside Retreat", 299132.00);

            var premium = new PremiumUpgrade(ssh1);

            Console.WriteLine(premium.GetPrice());

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    public class Drinks : CafeAssortment
    {
        private double _volume;
        public Drinks(double volume, string dishName, double price, string category, double weight)
           : base(dishName, price, category, weight)
        {
            _volume = volume;
        }

        public override string Information()
        {
            return base.Information();
        }

        public override string CostOfDrink(int percent)
        {
            return base.CostOfDrink(15);
        }
    }

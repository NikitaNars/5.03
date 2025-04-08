using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    public class RollerCoaster : Attractions
    {
        public RollerCoaster(string name, double duration, int maxSeats, double price) : base(name, duration, maxSeats, price) { }

        public override double GetRevenue(int people = 0)
        {
            return base.GetRevenue(people);
        }

        public override string Information()
        {
            return base.Information();
        }
    }
}

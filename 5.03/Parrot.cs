using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    public class Parrot : Animals
    {
        public Parrot(string name, string breed, string birthDate, double weight) : base(name, breed, birthDate, weight) { }

        public override string Information()
        {
            return base.Information();
        }
    }
}

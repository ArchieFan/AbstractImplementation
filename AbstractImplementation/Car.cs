using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    internal abstract class Car
    {
        public string Wheel()
        {
            return "4 wheeler";
        }
        public string CheckAC()
        {
            return "AC is available";
        }
        public string CallFacility()
        {
            return "Call Facility supported";
        }

        public abstract double price();

        public abstract int getTotalSeat();

        public abstract string colors();

    }
}

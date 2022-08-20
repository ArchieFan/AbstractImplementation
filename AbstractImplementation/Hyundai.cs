using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    internal class Hyundai : Car
    {
        public override int getTotalSeat()
        {
            return 7;
        }
        static void Main()
        {
            Hyundai dust = new Hyundai();
            Console.WriteLine(dust.CallFacility());
            Console.WriteLine(dust.Wheel());
            Console.WriteLine(dust.CheckAC());
            Console.WriteLine(dust.getTotalSeat());
            Console.ReadLine();
        }

        public override double price()
        {
            throw new NotImplementedException();
        }

        public override string colors()
        {
            throw new NotImplementedException();
        }
    }
}

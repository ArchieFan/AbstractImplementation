using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    internal class Toyota : Car
    {
        private string DiscountPrice()
        {
            return "20% discount on buying Toyoya Cars";
        }

        public override double price()
        {
            return 12000;
        }
        static void Main()
        {
            Toyota Toy = new Toyota();

            Console.WriteLine(Toy.CallFacility());
            Console.WriteLine(Toy.Wheel());
            Console.WriteLine(Toy.CheckAC());
            Console.WriteLine(Toy.DiscountPrice());
            Console.WriteLine(Toy.price());
            Console.ReadLine();
        }

        public override int getTotalSeat()
        {
            throw new NotImplementedException();
        }

        public override string colors()
        {
            throw new NotImplementedException();
        }
    }
}

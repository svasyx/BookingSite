using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class OneRoomFlat:Dwelling
    {

        public OneRoomFlat()
        {

        }

        public OneRoomFlat(string address, double square, double pricePerDay) : base(address, square, pricePerDay)
        {

        }

        public override string GetString()
        {
            return base.GetString();
        }
    }
}

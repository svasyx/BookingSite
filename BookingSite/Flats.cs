using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Flats: Dwelling
    {
        protected int _bedroomsCount { get; set; } = 1;

        public Flats()
        {
          _bedroomsCount = 1;
        }

        public Flats(int bedroomsCount)
        {
            _bedroomsCount = bedroomsCount;
        }

        public Flats(int bedroomsCount, string address, double square, double pricePerDay) : base(address, square, pricePerDay)
        {
            _bedroomsCount = bedroomsCount;
        }

        public int GetBedCount()
        {
            return _bedroomsCount;
        }

        public override string GetString()
        {
            return base.GetString() + $"Bedrooms count: {_bedroomsCount}";
        }

    }
}

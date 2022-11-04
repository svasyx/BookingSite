using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class House:Dwelling
    {
        protected int _flourCount { get; set; } = 1;

        public House()
        {
            _flourCount = 1;
        }

        public House(int flourCount)
        {
            _flourCount = flourCount;
        }

        public House(int flourCount, string address, double square, double pricePerDay) : base(address, square, pricePerDay)
        {
            _flourCount = flourCount;
        }

        public int GetBedCount()
        {
            return _flourCount;
        }

        public override string GetString()
        {
            return base.GetString() + $"Dlour count: {_flourCount}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class ChillHouse: Dwelling
    {
        protected string _goods { get; set; } = null;

        public ChillHouse()
        {
            _goods = "No goods, only chill";
        }

        public ChillHouse(string goods)
        {
            if (!String.IsNullOrEmpty(goods))
            {
                _goods = goods;
            }
            
        }

        public ChillHouse(string goods, string address, double square, double pricePerDay) : base(address, square, pricePerDay)
        {
            if (!String.IsNullOrEmpty(goods))
            {
                _goods = goods;
            }

        }

        public override string GetString()
        {
            return base.GetString() + $"goods:{_goods} ";
        }


    }
}

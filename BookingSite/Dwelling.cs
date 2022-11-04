using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Dwelling
    {

        protected string _address { get; set; } = null;
        protected double _square { get; set; } = 0;

        protected double _pricePerDay { get; set;} = 0;
        public List<Dwelling> dwellings { get; set; } = null;

        public Dwelling()
        {
            _address = null;
            _square = 0;
            _pricePerDay = 0;
            dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square,double pricePerDay)
        {
            if(!String.IsNullOrEmpty(address))
            {
                _address = address;
            }
            
            _square = square;
            _pricePerDay = pricePerDay; 

            dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square,double pricePerDay, List<Dwelling> dwellings) : this(address, square,pricePerDay)
        {
            if (!String.IsNullOrEmpty(address))
            {
                _address = address;
            }

            _square = square;
            pricePerDay = pricePerDay;

            this.dwellings = dwellings;
        }
        public string GetAddress()
        {
            string address = null;
            address = _address;

            return address;
        }

        public double GetSquare()
        {

            return _square;
        }
        public double GetPrice()
        {

            return _pricePerDay;
        }

        public List<Dwelling> GetList()
        {

            return dwellings;
        }

        public virtual string GetString()
        {

            return $"Address: {_address} and square: {_square} and price {_pricePerDay} ";
        }

    }
}

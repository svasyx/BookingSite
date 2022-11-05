using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Dwelling
    {

        protected string _address { get; set; } = String.Empty;
        protected double _square { get; set; } = 0;

        protected double _pricePerDay { get; set;} = 0;
        protected List<Dwelling> _dwellings { get; set; }

        public Dwelling()
        {
            _address = String.Empty;
            _square = 0;
            _pricePerDay = 0;
            _dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square,double pricePerDay)
        {
            if(!String.IsNullOrEmpty(address))
            {
                _address = address;
            }
            
            _square = square;
            _pricePerDay = pricePerDay; 

            _dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square,double pricePerDay, List<Dwelling> dwellings) : this(address, square,pricePerDay)
        {
            if (!String.IsNullOrEmpty(address))
            {
                _address = address;
            }

            _square = square;
            _pricePerDay = pricePerDay;

            this._dwellings = dwellings;
        }

        public void SetAddress(string Address)
        {
            _address = Address;
        }
        public string GetAddress()
        {
            string address;
            address = _address;

            return address;
        }

        public void SetSquare(double square)
        {
           _square = square;
        }
        public double GetSquare()
        {

            return _square;
        }

        public void SetPrice(double Price)
        {
            _pricePerDay = Price;
        }
        public double GetPrice()
        {

            return _pricePerDay;
        }

        public List<Dwelling> GetList()
        {

            return _dwellings;
        }

        public void SetList(Dwelling obj)
        {
            _dwellings.Add(obj);
        }
        public virtual string GetString()
        {

            return $"Address: {_address} and square: {_square} and price {_pricePerDay} ";
        }

    }
}

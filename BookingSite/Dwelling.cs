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
        public List<Dwelling> dwellings { get; set; } = null;

        public Dwelling()
        {
            _address = null;
            _square = 0;
            dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square)
        {
            if(!String.IsNullOrEmpty(address))
            {
                _address = address;
            }
            
            _square = square;

            dwellings = new List<Dwelling>();
        }

        public Dwelling(string address, double square, List<Dwelling> dwellings) : this(address, square)
        {
            if (!String.IsNullOrEmpty(address))
            {
                _address = address;
            }

            _square = square;

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

        public List<Dwelling> GetList()
        {

            return dwellings;
        }

        public virtual string GetString()
        {

            return $"Address: {_address} and square: {_square} ";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Hotel: Dwelling
    {
        protected int _roomsNumber { get; set; } = 0;

        public Hotel()
        {
            _roomsNumber = 0;
        }

        public Hotel(int roomsNumber)
        {
            _roomsNumber = roomsNumber;
        }

        public Hotel(int roomsNumber, string address, double square, double pricePerDay) : base(address, square, pricePerDay)
        {
            _roomsNumber = roomsNumber;
        }

        public void SetRoomsNumber(int roomsNumber)
        {
            _roomsNumber = roomsNumber;
        }

        public int GetRoomsNumber()
        {
          return _roomsNumber;
        }

        public override string GetString()
        {

            return base.GetString() + $"number of rooms: {_roomsNumber}";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Hotel: Dwelling
    {
        public int _roomsNumber { get; set; } = 0;

        public Hotel()
        {
            _roomsNumber = 0;
        }

        public Hotel(int roomsNumber)
        {
            _roomsNumber = roomsNumber;
        }

        public Hotel(int roomsNumber, string address, double square) : base(address,square)
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

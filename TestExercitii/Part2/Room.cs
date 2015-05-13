using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii.Part2
{
    class Room
    {
        public string description;
        public int places, number, floor;
        RoomTypes type;

        public enum RoomTypes
        {
            Single,
            Double,
            Twin,
            Duplex,
            KingBedroom
        }

    }
  
}

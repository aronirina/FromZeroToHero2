using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii.Part2
{
    class Room
    {
        //Part3, Ex2
        private string description;
        private int places, number, floor;
        private RoomTypes type;

        public RoomTypes roomType
        {
            get { return type; }
            set { type = value; }
        }
        public string roomDesc
        {
            get { return description; }
            set
            {
                if (value.Length > 500)
                    Console.WriteLine("Error! Wrong description!");
                else
                    description = value;
            }
        }
        
        //Part3, Ex4

        public bool airCond {get; set;}
        public bool flatTV {get; set;}

        //Part2
        public Room(int number, string description, int places, int floor, RoomTypes type)
        {
            this.number = number;
            this.description = description;
            this.places = places;
            this.floor = floor;
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Room {0}", number);
            Console.WriteLine("\t Description: {0}", description);
            Console.WriteLine("\t Maximum allowed persons: {0}", places);
            Console.WriteLine("\t Floor: {0}", floor);
            Console.WriteLine("\t Type: {0}", type);
        }       
    }
    public enum RoomTypes
    {
        Single,
        Double,
        Twin,
        Duplex,
        KingBedroom
    }
  
}

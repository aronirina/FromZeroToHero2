using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii.Part2
{
    class GuestHouse : Property
    {
        private string name, description, address;
        private int stars;
        private double distanceToCenter;
        private DateTime openingDate;
        public Room[] Rooms { get; set; }

        public int comfortIn { get; set; }

        public GuestHouse(string name, string description, string address, int stars,
                     double distanceToCenter, DateTime openingDate, Room[] rooms, int comfortIn)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.Rooms = rooms;
            this.comfortIn=comfortIn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of GuestHouse: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Stars: {0}", new string('*', stars));
            Console.WriteLine("Distance to center: {0} km", distanceToCenter);
            Console.WriteLine("Opening Date: {0}", openingDate.ToShortDateString());
            foreach (Room room in Rooms)
            {
                room.DisplayInfo();
            }
            Console.WriteLine("Comfort Index: {0}", comfortIn);
        }
    }
}

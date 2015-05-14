using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii.Part2
{
    class Hotel
    {
        //Part3, Ex 1
      
        private string name, description, address;
        private int stars;
        private double distanceToCenter;
        private DateTime openingDate;
        public Room[] Rooms{get;set;}

        public string hotelName
        {
            get { return name; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! Name has more than 50 characters!");
                else
                    name = value;
            }
        }
        public string hotelDesc
        {
            get { return description; }
            set
            {
                if (value.Length > 500)
                    Console.WriteLine("Error! Description has more than 500 characters!");
                else
                    description = value;
            }
        }
        public string hotelAdress
        {
            get { return address; }
            set
            {
                if (value.Length > 100)
                    Console.WriteLine("Error! Address has more than 100 characters");
                else
                    address = value;
            }
        }
        public int hotelStars
        {
            get { return stars; }
            set
            {
                if (value < 0 || value > 5)
                    Console.WriteLine("Error! Wrong number of stars!");
                else
                    stars = value;
            }
        }
        public double hotelDTC
        {
            get { return distanceToCenter; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Error! Wrong distance!");
                else
                    distanceToCenter = value;
            }
        }
        public DateTime hotelOD
        {
            get { return openingDate; }
            set
            {
                if (value < new DateTime(1800, 1, 1) || value > DateTime.Now)
                    Console.WriteLine("Error! Wrong opening date!");
                else
                    openingDate = value;
            }
        }

        //Part 3, Ex4

        public bool inPool { get; set; }
        public bool WiFi { get; set; }

        //Part 3, Ex5

        public Hotel()
        { }

        //Part2

        private static string distanceMesurementUnit;

        static Hotel()
        {
            distanceMesurementUnit = "Miles";
        }


        public static void SetDistanceMesurementUnit(string measurementUnit)
        {
            distanceMesurementUnit = measurementUnit;
        }

        public static string GetDistanceMesurementUnit()
        {
            return distanceMesurementUnit;
        }

        public string DistanceConvertor(string measurementUnit)
        {
            if (measurementUnit=="Miles")
            {
                distanceToCenter = distanceToCenter * 1.609;
                measurementUnit = "KM";
            }
            else
            {
                distanceToCenter = distanceToCenter / 1.609;
                measurementUnit = "Miles";
            }
            return measurementUnit;
        }

        public Hotel(string name, string description, string address, int stars,
                     double distanceToCenter, DateTime openingDate, Room[] rooms)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.Rooms = rooms;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Details of Hotel: {0}", name);
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Stars: {0}", new string('*', stars));
            Console.WriteLine("Distance to center: {0} km", distanceToCenter);
            Console.WriteLine("Opening Date: {0}", openingDate.ToShortDateString());
            foreach (Room room in Rooms)
            {
                room.DisplayInfo();
            }
        }
      
    }
}

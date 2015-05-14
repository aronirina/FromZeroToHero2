using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii.Part2
{
    class ExPart2
    {

        public static void Main()
        {
            //Part 2

            /*
            Hotel hotel = new Hotel();
            hotel.name = "Unirea Hotel";
            hotel.description = @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.";
            hotel.address = "Piaţa Unirii Street No. 5, 700056 Iaşi, Romania";
            hotel.stars = 4;
            hotel.distanceToCenter = 1.6;
            hotel.openingDate = new DateTime(1975, 10, 25);

            Room room1 = new Room();
            room1.type = RoomTypes.Single;
            room1.description = @"A beautiful room for 1 person with all facilities inclued";
            room1.places = 1;
            room1.number = 1;
            room1.floor = 2;

            Room room2 = new Room();
            room2.type = RoomTypes.Double;
            room2.description = @"A beautiful room for 2 person with a beautiful view towords the city cener";
            room2.places = 2;
            room2.number = 2;
            room2.floor = 7;

            hotel.rooms = new Room[] { room1, room2 };

            Console.WriteLine("Hotel name: {0}", hotel.name);
            Console.WriteLine("Hotel address: {0}", hotel.address);
            Console.WriteLine("Hotel opening year: {0}", hotel.openingDate.Year);
            Console.WriteLine("Hotel ");
           

            Room room1 = new Room(1, @"A beautiful room for 1 person with all facilities inclued", 1,
                                  2, RoomTypes.Single);
             */

            Room room2 = new Room(2, @"A beautiful room for 2 person with a beautiful view towords the city cener", 2,
                                   7, RoomTypes.Double);

           /* Hotel hotel = new Hotel("Unirea Hotel", @"Unirea Hotel is one of the most good looking hotel in Iasi Romania.",
                                    @"Piaţa Unirii Street No. 5, 700056 Iaşi, Romania", 4, 1.6, new DateTime(1975, 10, 25),
                                    new Room[] { room1, room2 });

            hotel.DisplayInfo();
            */
            Property hotelAstoria = new Property("Astoria", @"Astora Hotel is an excellent place to stay while in Iasi",
                                    @"Piata Unirii Street No. 7 Iasi, Romania", 5, 1.8, new DateTime(1990, 12, 19),
                                    new Room[] { room2 });

            Property.SetDistanceMesurementUnit("KM");
            Console.WriteLine("Distance measurement unit is {0}", Property.GetDistanceMesurementUnit());

            //hotel.DisplayInfo();
            //hotelAstoria.DistanceConvertor("KM");
            //hotelAstoria.DisplayInfo();

            //Part 3, Ex3

            Property htl=new Property();
            htl.Rooms = new Room[0];
            htl.DisplayInfo();
        }
    }
}
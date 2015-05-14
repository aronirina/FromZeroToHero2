using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {
        /*  static void day(DateTime date)
          {
            if (date.DayOfWeek==DayOfWeek.Saturday || date.DayOfWeek==DayOfWeek.Sunday)
                Console.WriteLine(date.ToString("dddd"));
          }
      

          public enum seasons
          {
              sprind = 1,
              summer,
              autumn,
              winter
          }
          static void SeasonMet(seasons x)
          {
              for (int i=1; i<=seasons.)
              {

              }
          }
           

        public static string LargestNamedCountry(params string[] countries)
        {
            string largestCountry = string.Empty;
            foreach (string country in countries)
            {
                if (country.Length > largestCountry.Length)
                {
                    largestCountry = country;
                }
            }
            return largestCountry;
        }

        public static void TestExercise()
        {
            string[] countries = new string[] { "Romania", "Spain", "Germany", "United States of America" };
            string largestCountry = LargestNamedCountry(countries);
            Console.WriteLine("Largest country name is {0} and has {1} letters ", largestCountry, largestCountry.Length);
        }


       static void PriceWithDiscount(double price, int age, out double pwd)
        {
            double discount;
            if (age < 7)
                discount = price * 25 / 100;
            else if (age >= 7 && age <= 14)
                discount = price * 15 / 100;
            else
                discount = price * 5 / 100;

            pwd = price - discount;            
        }

       static void NewPrice(ref double price, int age)
       {
           
           if (age < 7)
               price = price - price * 25 / 100;
           else if (age >= 7 && age <= 14)
               price = price - price  * 15 / 100;
           else
               price = price - price * 5 / 100;

       }

     static double PriceWithDiscount(double price, int age, double pwd)
       {
           double discount;
           if (age < 7)
               discount = price * 25 / 100;
           else if (age >= 7 && age <= 14)
               discount = price * 15 / 100;
           else
               discount = price * 5 / 100;

        pwd = price - discount;
        return pwd;
       }
       public enum DiscountType
       {
           General,
           Promotion,
           BestDeal
       }
       
        static void exercise7(DiscountType disc, double price, int age, out double pwd)
       {
           double p;
            switch(DiscountType)
            {
                case DiscountType.General:
                    {
                        p=PriceWithDiscount(price, age, out pwd);
                        Console.WriteLine("General Discount is {0}", p);
                    }
                case DiscountType.Promotion:
                    {
                        p=price-
                    }

            }
       }
        

        static double CalculateDiscount(double price,  int age=14, DiscountType discountType=DiscountType.General)
       {
         
           double priceWithDiscount;
           if (age < 7)
           {
               priceWithDiscount = price - price * 0.25;
           }
           else if (age >= 7 && age < 14)
           {
               priceWithDiscount = price - price * 0.15;
           }
           else
           {
               priceWithDiscount = price - price * 0.05;
           }

           switch (discountType)
           {
               case DiscountType.Promotion:
                   {
                       priceWithDiscount = priceWithDiscount - priceWithDiscount * 0.25;
                       break;
                   }
               case DiscountType.BestDeal:
                   {
                       priceWithDiscount = priceWithDiscount - priceWithDiscount * 0.5;
                       break;
                   }
           }
           return priceWithDiscount;
       }

        static void Main(string[] args)
        {
            TestExercise();
            double pwd;
            PriceWithDiscount(47.5, 12, out pwd);
            Console.Write("Price with discount is {0}", pwd);
            double price = 52.53;
            NewPrice(ref price, 18);
            Console.Write("The new Price is {0}", price);

            double priceWD;
            priceWD= CalculateDiscount(234.7);
            Console.WriteLine("Call price: {0}", priceWD);
           // priceWD = CalculateDiscount(24.8 ,discountType = DiscountType.BestDeal);
        }
         */
    }
}

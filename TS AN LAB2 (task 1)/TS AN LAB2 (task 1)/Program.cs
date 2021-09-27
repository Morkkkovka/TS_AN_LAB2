using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task_1_
    

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть країну: ");
            string Country = Console.ReadLine();
            Console.WriteLine("Введіть місто: ");
            string City = Console.ReadLine();
            Console.WriteLine("Введіть вулицю: ");
            string Street = Console.ReadLine();
            Console.WriteLine("Введіть індекс: ");
            int Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть номер будинку: ");
            int House = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть квартиру: ");
            int Apartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ти живеш по адресу {Country}, місто {City}, вулиця {Street}, будинок {House}, квартира {Apartment}. індекс {Index}");

        }
    }


    class Address
    {

        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House{ get; set; }
        public int Apartment { get; set; }

           
     
        public Address(string country, string city, string street, int index, int house, int apartment)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            Index = index;
            House = house;
            Apartment = apartment;
        }

      



    }

   
}

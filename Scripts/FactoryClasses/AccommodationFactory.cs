using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.FactoryClasses
{
    public class AccommodationFactory
    {   

        public static AccommodationPlace CreateAccommodationPlace(string name, string email,string numberOfRooms,string openAdress,
                                                                   string phoneNumber,string starNumber,string city,string district)
        {

            AccommodationPlace hotel = new Hotel()
            {
                Name = name,
                Adress = GetAdress(openAdress,city,district,phoneNumber,email),
                StarCount = Convert.ToInt32(starNumber),
                Rating = 0,
            };



            return hotel;
        }


        private static  Address GetAdress(string openAdress,string city,string district,string phoneNumber,string email)
        {
            Address address = new HotelAdress()
            {
                City = city,
                District = district,
                OpenAdress = openAdress,
                PhoneNumber = phoneNumber,
                Email = email
                    
            };

            return address;
        }

    }
}

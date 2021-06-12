using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.FactoryClasses
{
    public class PersonelFactory
    {


        public static Personel GetPersonel(string openAdress, string mail, string name, string phoneNumber
                                            , string identityNumber, string department, string position)
        {

            return new HotelPersonel()
            {
                Name = name,
                IdentificationNumber = identityNumber,
                Address = GetAdress(openAdress,"","",phoneNumber,mail),
                Department = (Department)Enum.Parse(typeof(Department), department, true),
                Position = (Position)Enum.Parse(typeof(Position), department, true),
        };

        }


        private static Address GetAdress(string openAdress, string city, string district, string phoneNumber, string email)
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

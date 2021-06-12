using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.GetDummyData
{
    public class GetDummyHotels
    {
        private string[] hotelNameList = { "Ada Hotel", "Resort Hotel", "Swiss Hotel", "Maxx Royal"};
        private Address[] hotelAdress = {
            new HotelAdress() { 
                
                City = "Muğla",
                District = "Marmaris",
                OpenAdress = "Muğla Marmaris",
                PhoneNumber = "5438524147",
                Email = "adaotel@gmail.com"
            },
             new HotelAdress() {

                City = "Muğla",
                District = "Marmaris",
                OpenAdress = "Muğla Marmaris",
                PhoneNumber = "5434524147",
                Email = "resortadaotel@gmail.com"
            },
              new HotelAdress() {

                City = "Antalya",
                District = "Belek",
                OpenAdress = "Antalya Belek",
                PhoneNumber = "5418524147",
                Email = "swissotel@gmail.com"
            },
               new HotelAdress() {

                City = "Antalya",
                District = "Belek",
                 OpenAdress = "Antalya Belek",
                PhoneNumber = "5439524147",
                Email = "maxxroyal@gmail.com"
            },
        };
        private int[] starCounts = { 4, 5, 4, 5 };
        private float[] ratings = { 4.1f, 4.9f, 4.3f, 5.0f };
        private Comment[] comments =
        {
            new HotelCommet()
            {
                CommenterName = "Mehmet",
                CommenterEmail = "m@m.gmail.com",
                CommentContent = "this hotel is wonderdull",
                GivenScore = 4.1f
            },
             new HotelCommet()
            {
                CommenterName = "Arda",
                CommenterEmail = "a@m.gmail.com",
                CommentContent = "this hotel is wonderdull",
                GivenScore = 4.9f
            },
              new HotelCommet()
            {
                CommenterName = "serdar",
                CommenterEmail = "s@m.gmail.com",
                CommentContent = "this hotel is wonderdull",
                GivenScore = 4.3f
            },
               new HotelCommet()
            {
                CommenterName = "mustafa",
                CommenterEmail = "musstda@m.gmail.com",
                CommentContent = "this hotel is wonderdull",
                GivenScore = 5.0f
            },


        };
        private Personel[] personels =
        {
           new HotelPersonel()
           {
               Name = "Mehmet",
               IdentificationNumber ="12345678998",
               Address = new PersonelAdress()
               {
                   City ="Ankara",
                   District = "Gölbaşı",
                   OpenAdress = "Ankara Gölbaşı",
                   PhoneNumber = "03127458965",
                   Email = "m@mgmail.com"
               },
               Department = Department.Computing,
               Position = Position.ITStaff
           },

           new HotelPersonel()
           {
               Name = "Serdar",
               IdentificationNumber ="22345678998",
               Address = new PersonelAdress()
               {
                   City ="İzmir",
                   District = "Göztepe",
                   OpenAdress = "İzmir Göztepe",
                   PhoneNumber = "8747458965",
                   Email = "s@mgmail.com"
               },
               Department = Department.Accounting,
               Position = Position.Manager
           },

           new HotelPersonel()
           {
               Name = "Mustafa",
               IdentificationNumber ="21345678998",
               Address = new PersonelAdress()
               {
                   City ="İzmir",
                   District = "Göztepe",
                   OpenAdress = "İzmir Göztepe",
                   PhoneNumber = "8747458965",
                   Email = "s@mgmail.com"
               },
               Department = Department.FoodAndBeverage,
               Position = Position.Manager
           },
             new HotelPersonel()
           {
               Name = "Arda",
               IdentificationNumber ="21345678998",
               Address = new PersonelAdress()
               {
                   City ="İzmir",
                   District = "Göztepe",
                   OpenAdress = "İzmir Göztepe",
                   PhoneNumber = "8747458965",
                   Email = "s@mgmail.com"
               },
               Department = Department.HumanResources,
               Position = Position.Manager
           }


        };

        public List<AccommodationPlace> AddDummyHotel()
        {

            List<AccommodationPlace> newHotels = new List<AccommodationPlace>();

            for (int i = 0; i < hotelNameList.Length; i++)
            {

                AccommodationPlace newHotel = new Hotel()
                {
                    Name = hotelNameList[i],
                    Adress = hotelAdress[i],
                    StarCount = starCounts[i],
                    Rating = ratings[i],
                };

                newHotel.Comments.Add(comments[i]);
                newHotel.Personels.Add(personels[i]);
                newHotels.Add(newHotel);
            }

            return newHotels;

        }


    }
}

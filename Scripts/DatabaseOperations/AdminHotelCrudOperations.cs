using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;


namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass
{
    public class AdminHotelCrudOperations : IDbAdminAccomodationPlaceCrudOperations
    {

        private HotelData hotelData;

        public AdminHotelCrudOperations()
        {
            hotelData = HotelData.Instance;
        }

        public bool DeleteAccommodationPlace(AccommodationPlace deletedAccommodationPlace)
        {
            throw new NotImplementedException();
        }

        public AccommodationPlace FindAccommodationPlace(string name)
        {
            throw new NotImplementedException();
        }

        public bool SaveNewAccomodationPlace(AccommodationPlace addedAccommodationPlace)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccommodationPlace(AccommodationPlace updatedAccommodationPlace)
        {
            throw new NotImplementedException();
        }
    }
}

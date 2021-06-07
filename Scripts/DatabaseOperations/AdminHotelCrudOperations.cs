using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
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

       

        public void print()
        {
            int x;
            int y;
            int z;
        }

        public bool DeleteAccommodationPlace(string deletedAccommodationPlaceName)
        {
            return hotelData.HotelsData.Delete(deletedAccommodationPlaceName);
        }

        public AccommodationPlace FindAccommodationPlace(string name)
        {
            try
            {
                return hotelData.HotelsData.Search(name).Data;
            }
            catch (Exception)
            {

                return null;
            }

           
        }

        public bool SaveNewAccomodationPlace(AccommodationPlace addedAccommodationPlace)
        {
            BSTNode<AccommodationPlace, string> bSTNode = new BSTNode<AccommodationPlace, string>(addedAccommodationPlace, addedAccommodationPlace.Name);

            hotelData.HotelsData.AddNode(bSTNode);
            return true;
        }

        public bool UpdateAccommodationPlace(AccommodationPlace updatedAccommodationPlace)
        {
            BSTNode<AccommodationPlace, string> bSTNode = hotelData.HotelsData.Search(updatedAccommodationPlace.Name);

            if (bSTNode != null)
            {
                bSTNode.Data = updatedAccommodationPlace;
                return true;
            }
            else
                return false; // otel not found exception.
        }
    }
}

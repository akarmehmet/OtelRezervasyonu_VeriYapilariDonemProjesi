using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System.Collections.Generic;
using System.Linq;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations
{
    public class AdminHotelPersonelCrudOperations : IDbAdminPersonelCrudOperations
    {

        private HotelData hotelData;
        public AdminHotelPersonelCrudOperations()
        {
            hotelData = HotelData.Instance;
        }

        public bool AddNewPersonelToDb(Personel addedPersonel, string accommodationPlaceName)
        {
            BSTNode<AccommodationPlace, string> hotel = hotelData.HotelsData.Search(accommodationPlaceName);

            if (hotel == null)
                return false;

            hotel.Data.Personels.Add(addedPersonel);
            return true;

        }

        public bool DeletePersonelFormDb(string identificationNumber, string accommodationPlaceName)
        {
            BSTNode<AccommodationPlace, string> hotel = hotelData.HotelsData.Search(accommodationPlaceName);

            if (hotel == null)
                return false;

            Personel deletedPersonel = hotel.Data.Personels.SingleOrDefault(p => p.IdentificationNumber == identificationNumber);
            if (deletedPersonel == null)
                return false;

            hotel.Data.Personels.Remove(deletedPersonel);
            return true;
        }

        public List<Personel> GetPersonelByDepartment(Department department, string accommodationPlaceName)
        {
            BSTNode<AccommodationPlace, string> hotel = hotelData.HotelsData.Search(accommodationPlaceName);

            if (hotel == null)
                return null;

            return hotel.Data.Personels; // show departmant info in Form Class


        }

        public bool UpdatePersonelInfo(Personel updatedPersonel, string accommodationPlaceName)
        {
            BSTNode<AccommodationPlace, string> hotel = hotelData.HotelsData.Search(accommodationPlaceName);

            if (hotel == null)
                return false;

            Personel uPersonel = hotel.Data.Personels.SingleOrDefault(p => p.IdentificationNumber == updatedPersonel.IdentificationNumber);
            if (uPersonel == null)
                return false;

            uPersonel = updatedPersonel;

            return true;
        }
    }
}

using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces
{
    public interface IDbAdminAccomodationPlaceCrudOperations
    {

        bool SaveNewAccomodationPlace(AccommodationPlace addedAccommodationPlace);

        bool DeleteAccommodationPlace(string deletedAccommodationPlaceName);

        bool UpdateAccommodationPlace(AccommodationPlace updatedAccommodationPlace);

        AccommodationPlace FindAccommodationPlace(string name);

        List<AccommodationPlace> GetAccommodationPlacesByInOrder();

        bool AddNewRoomToAccommodationPlace(string capacity, string hotelName,string landscapeInfo,string phone,string price,string roomNo);
        bool DeleteRoomFromAccommodationPlace(string hotelName,string roomNo);


    }
}

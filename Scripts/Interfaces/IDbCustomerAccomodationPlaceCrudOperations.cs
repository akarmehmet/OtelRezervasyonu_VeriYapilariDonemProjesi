using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces
{
    public interface IDbCustomerAccomodationPlaceCrudOperations
    {
        List<AccommodationPlace> GetAccommodationPlacesOrderByName();

        List<AccommodationPlace> GetAccommodationPlacesOrderByProvinceAndDistrict(string province, string district);

        List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByScore(string province, string district);

        List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByStar(string province, string district);

        List<AccommodationPlace> GetAccommodationPlacesByPreOrder();

        List<AccommodationPlace> GetAccommodationPlacesByPostOrder();

        List<AccommodationPlace> GetAccommodationPlacesByInOrder();

        int GetAccommodationPlacesDepth();
        
        int GetAccommodationPlacesCount();

        bool MakeReservation(string nameOfAccommodationPlace);


        bool MakeCommentAndGiveScoreAccommodationPlace(string nameOfAccommodationPlace, Comment comment);

        AccommodationPlace FindAccommodationPlace(string name);




    }
}

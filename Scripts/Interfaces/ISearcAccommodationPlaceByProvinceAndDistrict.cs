using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces
{
    public interface ISearcAccommodationPlaceByProvinceAndDistrict
    {

        List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByScore(string province, string district);
        List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByStar(string province, string district);
        List<AccommodationPlace> GetAccommodationPlacesOrderByProvinceAndDistrict(string province, string district);
    }
}

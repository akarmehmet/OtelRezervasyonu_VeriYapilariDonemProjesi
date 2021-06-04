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


    }
}

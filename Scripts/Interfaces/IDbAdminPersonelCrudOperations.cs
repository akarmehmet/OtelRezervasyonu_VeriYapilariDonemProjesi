using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces
{
    public interface IDbAdminPersonelCrudOperations
    {
        bool AddNewPersonelToDb(Personel addedPersonel,string AccommodationPlaceName);
        bool DeletePersonelFormDb(string identificationNumber, string AccommodationPlaceName);
        bool UpdatePersonelInfo(Personel updatedPersonel, string AccommodationPlaceName);
        List<Personel> GetPersonelByDepartment(Department department, string AccommodationPlaceName);

    }
}

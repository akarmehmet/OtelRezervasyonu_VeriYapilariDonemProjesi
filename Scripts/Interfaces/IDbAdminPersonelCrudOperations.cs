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
        bool AddNewPersonelToDb(Personel addedPersonel);
        bool DeletePersonelFormDb(string identificationNumber);
        bool UpdatePersonelInfo(Personel updatedPersonel);
        List<Personel> GetPersonelOrderByAccommodationPlace();
        List<Personel> GetPersonelByDepartment(Department department);

    }
}

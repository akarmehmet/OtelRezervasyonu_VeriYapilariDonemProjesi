using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums
{
    public enum LandscapeInformation
    {
        Mountain,
        Sea,
        Plateau,
        Throat, 
        Valley,
        City,


    }

    public enum Department
    {
        FrontOffice,
        FoodAndBeverage,
        Housekeeping,
        Marketing,
        Accounting,
        HumanResources,
        Security,
        Computing,
        Staff,
        TechnicalService
    }

    public enum Position
    {
        Manager,
        AssistantDirector,
        Chef, 
        SecurityGuard, 
        ReceptionChief,
        WarehouseSupervisor, 
        Dishwasher,
        ITStaff, 
        PurchasingManager

    }
}

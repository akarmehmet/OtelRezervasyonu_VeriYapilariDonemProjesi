using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Singleton;


namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData
{
    public class HotelData : Singleton<HotelData>
    {

        public HotelTrees HotelsData   { get; set; }

        public HotelData()
        {

            if (HotelsData == null)
                HotelsData = new HotelTrees();
        }




    }
}

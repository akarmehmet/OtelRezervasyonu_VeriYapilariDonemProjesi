using OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.GetDummyData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Singleton;
using System.Collections.Generic;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData
{
    public class HotelData : Singleton<HotelData>
    {

        public HotelTrees HotelsData { get; set; }

        public HashLinearTable<Reservation> ReservationHashTable {get; set;}
        public List<HeapTrees<Reservation, int>> ReservationsHeap {get; set;}

        private GetDummyHotels getDummyHotels;

        public HotelData()
        {

            if (HotelsData == null)
                HotelsData = new HotelTrees();

            if (ReservationHashTable == null)
                ReservationHashTable = new ReservationHashTable();

            if (ReservationsHeap == null)
                ReservationsHeap = new List<HeapTrees<Reservation, int>>();

            if(getDummyHotels == null)
            {
                getDummyHotels = new GetDummyHotels();
                List<AccommodationPlace> newHotels = getDummyHotels.AddDummyHotel();
                foreach (var newHotel in newHotels)
                {
                    HotelsData.AddNode(new BSTNode<AccommodationPlace, string>(newHotel,newHotel.Name));
                }
            }
        }




    }
}

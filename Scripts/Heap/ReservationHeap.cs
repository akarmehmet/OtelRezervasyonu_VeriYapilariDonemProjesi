using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass
{
    public class ReservationHeap : HeapTrees<Reservation, int>
    {
        public ReservationHeap(int maxHeapSize) : base(maxHeapSize)
        {
        }
    }
}

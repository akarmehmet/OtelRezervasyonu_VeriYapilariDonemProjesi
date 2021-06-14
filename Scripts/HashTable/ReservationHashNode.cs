using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable
{
   public class ReservationHashNode : HashLinearNode<Reservation>
    {

        private int maxNumber;
        public HeapTrees<Customer, string> ReservationHeapTrees;

        public ReservationHashNode(int key, Reservation value,int maksimum) : base(key, value)
        {

            maxNumber = maksimum;


            ReservationHeapTrees = new ReservationHeap(maxNumber);

            Reservation reservation = (Reservation)Convert.ChangeType(value, typeof(Reservation));

            foreach (var customer in reservation.Customers)
            {

                ReservationHeapTrees.Insert(new HeapNode<Customer, string>(customer, customer.Name));
            }

        }
    }
}

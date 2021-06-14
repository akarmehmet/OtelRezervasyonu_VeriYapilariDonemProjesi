using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass
{
    public class ReservationHashTable : HashLinearTable<Reservation>
    {
        public override void AddNode(HashLinearNode<Reservation> node)
        {
            int hash = (node.Key % TABLE_SIZE);


            ReservationHashNode reservationHashNode = (ReservationHashNode)node;


            while (table[hash] != null && table[hash].Key != node.Key)
            {
                hash = (hash + 1) % TABLE_SIZE;
            }

            table[hash] = node;

            table[hash] = reservationHashNode;
        }
    }
}

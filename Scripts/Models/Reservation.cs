using System;
using System.Collections.Generic;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Reservation
    {
        public List<Customer> Customers { get; set; }
        public int ReservationNo { get; set; }
        public string ReservedPlaceName { get; set; }
        public int ReservedPlaceNo { get; set; }
        public int NumberOfReservedPlace { get; set; }
        public int NumberOfDay { get; set; }
        public float TotalPrice { get; set; }

        private static List<int> reservationNumbers = new List<int>();

        protected Reservation()
        {
            AssignParametre();

        }

        private void AssignParametre()
        {
            Customers = new List<Customer>();

            Random random = new Random();
            do
            {
                ReservationNo = random.Next(1000, 10000);
            } 
            while (reservationNumbers.Contains(ReservedPlaceNo));
            {
                ReservationNo = random.Next(1000, 10000);
            }
        }
    }
}

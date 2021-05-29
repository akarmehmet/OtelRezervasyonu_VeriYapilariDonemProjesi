using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Reservation
    {
        public Customer Customer { get; set; }
        public string ReservationNo { get; set; }
        public string ReservedPlaceName { get; set; }
        public int ReservedPlaceNo { get; set; }
        public int NumberOfReservedPlace { get; set; }
        public int NumberOfDay { get; set; }
        public float TotalPrice { get; set; }


    }
}

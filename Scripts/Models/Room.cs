using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Capacity { get; set; }
        public float Price { get; set; }
        public string RoomLandscapeInformation { get; set; }
        public bool ReservationStatus { get; set; }

       

    }
}

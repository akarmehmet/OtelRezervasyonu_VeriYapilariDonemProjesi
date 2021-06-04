using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class AccommodationPlace
    {
        public string Name { get; set; }
        public Address Adress { get; set; }
        public int StarCount { get; set; }
        public float Rating { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Personel> Personels { get; set; }

        protected AccommodationPlace()
        {
            Comments = new List<Comment>();
            Personels = new List<Personel>();
        }
    }
}

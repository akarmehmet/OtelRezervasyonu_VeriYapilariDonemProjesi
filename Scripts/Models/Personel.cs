using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Personel
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }
}

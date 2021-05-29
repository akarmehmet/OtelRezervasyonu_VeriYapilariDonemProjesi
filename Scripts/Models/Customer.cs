using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public Address Address { get; set; }


    }
}

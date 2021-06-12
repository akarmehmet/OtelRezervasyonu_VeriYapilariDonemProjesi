using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Address
    {
        public string City { get; set; }
        public string District { get; set; }
        public string OpenAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

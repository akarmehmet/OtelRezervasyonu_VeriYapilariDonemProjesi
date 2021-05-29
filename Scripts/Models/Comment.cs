using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models
{
    public abstract class Comment
    {
        public string CommenterName { get; set; }
        public string CommenterEmail { get; set; }
        public string CommentContent { get; set; }
        public float GivenScore { get; set; }
    }
}

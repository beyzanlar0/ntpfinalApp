using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntpfinalApp
{
    internal class Ders
    {
        public int DersId { get; set; }

       
        public string DersKod { get; set; }

        
        public string DersAd { get; set; }

        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}

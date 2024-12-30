using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntpfinalApp
{
    internal class Sinif
    {
        public int SinifId { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string SinifAd { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string SinifKontenjan { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
        public override string ToString()
        {
            return SinifAd;
        }
    }

}

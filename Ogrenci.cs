﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ntpfinalApp
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Ad { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Soyad { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Numara { get; set; }
        public int SinifId { get; set; }
        public override string ToString()
        {
            return $"{this.Numara}-{this.Ad}-{this.Soyad}";
        }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }

}

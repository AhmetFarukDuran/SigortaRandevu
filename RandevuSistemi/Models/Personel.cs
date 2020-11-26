using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandevuSistemi.Models
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
        public String PersonelAd { get; set; }
        public String PersonelSoyad { get; set; }
    }
}
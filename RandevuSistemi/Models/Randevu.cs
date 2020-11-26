using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandevuSistemi.Models
{
    public class Randevu
    {
        [Key]
        public int Randevuid { get; set; }
        public DateTime Tarih { get; set; }
        public bool Onay { get; set; }
        public int Kisiid { get; set; }
        public virtual Kisiler Kisiler { get; set; }
    }
}
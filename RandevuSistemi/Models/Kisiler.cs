using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandevuSistemi.Models
{
    public class Kisiler
    {
        [Key]
        public int Kisiid { get; set; }
        public string KisiAd { get; set; }
        public string KisiSoyad { get; set; }
        public int PoliceNo { get; set; }
        [Display(Name ="TcNo"),
            Required(ErrorMessage ="Boş Geçilemez"),
            RegularExpression(@"(^[1 - 9]{1}[0-9]{9}[02468]{1}$)",
            ErrorMessage ="Lütfen Tc Kimlik No Formatına Uygun Giriniz.")]
        public int TcNo { get; set; }
        public int Tel { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public ICollection<Randevu> Randevus { get; set; }
    }
}
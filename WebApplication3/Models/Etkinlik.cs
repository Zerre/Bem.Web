using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Etkinlik
    {
        public string Adi { get; set; }
        public EtkinlikTuru EtkinlikTuru { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string AltTur { get; set; }
    }
}
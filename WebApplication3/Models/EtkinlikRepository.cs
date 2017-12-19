using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public static class EtkinlikRepository
    {
        public static List<Etkinlik> Etkinlikler { get; set; }

        public static List<Etkinlik> ListeyiDoldur()
        {
            Etkinlikler = new List<Etkinlik>();

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "korku"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema2",
                BaslangicTarihi = DateTime.Now.AddDays(-10),
                BitisTarihi = DateTime.Now.AddDays(-5),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "korku"
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "dram"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema4",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "romantik"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema5",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "dram"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Sinema6",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Sinema,
                AltTur = "komedi"
            });

            //Tiyatro
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Tiyatro,
                AltTur = "genel"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro2",
                BaslangicTarihi = DateTime.Now.AddDays(2),
                BitisTarihi = DateTime.Now.AddDays(20),
                EtkinlikTuru = EtkinlikTuru.Tiyatro,
                AltTur = "genel"
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Tiyatro3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Tiyatro,
                AltTur = "genel"
            });

            //Muzik
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Muzik1",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Muzik,
                AltTur = "genel"
            });

            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Muzik2",
                BaslangicTarihi = DateTime.Now.AddDays(2),
                BitisTarihi = DateTime.Now.AddDays(20),
                EtkinlikTuru = EtkinlikTuru.Muzik,
                AltTur = "genel"
            });
            Etkinlikler.Add(new Etkinlik
            {
                Adi = "Muzik3",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now.AddDays(10),
                EtkinlikTuru = EtkinlikTuru.Muzik,
                AltTur = "genel"
            });

            return Etkinlikler;
        }
    }
}
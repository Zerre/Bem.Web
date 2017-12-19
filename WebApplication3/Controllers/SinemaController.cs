using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SinemaController : Controller
    {
        // GET: Sinema
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guncel()
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
                {
                    sinemaListesi.Add(sinema);
                }
            }

            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }

        public ActionResult tarih(string neZaman)
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
                {
                    if (neZaman == sinemaZamani.bugun.ToString())
                    {
                        if (sinema.BitisTarihi.Date == DateTime.Now.Date)
                        {
                            sinemaListesi.Add(sinema);
                            continue;
                        }
                    }
                    else if (neZaman == sinemaZamani.buhafta.ToString())
                    {
                        if (sinema.BitisTarihi <= DateTime.Now.AddDays(7))
                        {
                            sinemaListesi.Add(sinema);
                            continue;
                        }
                    }
                    else if (neZaman == sinemaZamani.buay.ToString())
                    {
                        if (sinema.BitisTarihi <= DateTime.Now.AddDays(30))
                        {
                            sinemaListesi.Add(sinema);
                            continue;
                        }
                    }
                }
            }

            return View("~/views/_shared/tarih.cshtml", sinemaListesi);
        }
    }
}
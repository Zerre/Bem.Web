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
                if ( sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
                {
                    sinemaListesi.Add(sinema);
                }
            }

            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }
    }
}
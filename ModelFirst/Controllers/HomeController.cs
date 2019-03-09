using ModelFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirst.Controllers
{
    public class HomeController : Controller // kontroler został stworzony
    {
        // GET: Home
        public ActionResult Index()
        {
            KontaktyModelContainer db = new KontaktyModelContainer(); // inicjalizacja klasy kontekstu
            var kontakt = db.KontaktySet.FirstOrDefault();            //pobranie jednego kontaktu w celu późniejszego                                                                    wyświetlenia go w indexie
            return View(kontakt);
        }
    }
}
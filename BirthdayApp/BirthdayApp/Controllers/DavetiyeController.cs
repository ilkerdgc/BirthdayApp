using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilanlar()
        {
            return Veritabanı.Liste.Where(x => x.KatilmaDurumu == true);
        }

        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilmayanlar()
        {
            return Veritabanı.Liste.Where(x => x.KatilmaDurumu == false);
        }

        [HttpPost]
        public void Ekle(DavetiyeModel davetiyeModel)
        {
            if (ModelState.IsValid)
            {
                Veritabanı.Add(davetiyeModel);
            }
            
        }
    }
}

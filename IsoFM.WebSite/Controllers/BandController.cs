using AutoMapper;
using IsoFM.Domain;
using IsoFM.Domain.Entities;
using IsoFM.Infra.Reporitory;
using IsoFM.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IsoFM.WebSite.Controllers
{
    public class BandController : Controller
    {
        BandRepository _bandRepository = new BandRepository();
        [OutputCache(Duration = 600, VaryByParam = "none")]
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<List<Band>, List<BandViewModel>>(_bandRepository.Obter());

            return View(viewModel);
        }

        [OutputCache(Duration = 600, VaryByParam = "id")]
        public ActionResult Details(string id)
        {
            if (id == null || string.IsNullOrEmpty(id) == true)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var band = _bandRepository.ObterPorId(id);            

            if (band == null)
            {
                return HttpNotFound();
            }

            var viewModel = Mapper.Map<Band, BandViewModel>(band);

            return View(viewModel);
        }
    }
}
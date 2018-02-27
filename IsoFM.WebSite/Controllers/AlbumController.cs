using AutoMapper;
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
    public class AlbumController : Controller
    {
        AlbumRepository _albumRepository = new AlbumRepository();
        BandRepository _bandRepository = new BandRepository();
        // GET: Album
        [OutputCache(Duration = 600, VaryByParam = "none")]
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<List<Album>, List<AlbumViewModel>>(_albumRepository.Obter());

            return View(viewModel);
        }

        [OutputCache(Duration = 600, VaryByParam = "idBand")]
        public ActionResult Details(string idBand)
        {
            if (idBand == null || string.IsNullOrEmpty(idBand) == true)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if(Discografia.BandCollection == null)
                Discografia.BandCollection = Mapper.Map<List<Domain.Band>, List<BandViewModel>>(_bandRepository.ObterFull());

            var albumDetais = Discografia.BandCollection.Where(b => b.Id == idBand).FirstOrDefault().AlbumList;

            List<AlbumViewModel> listaAlbum = new List<AlbumViewModel>();

            foreach (var item in albumDetais)
            {
                listaAlbum.Add(item.FirstOrDefault());
            }

            return PartialView(listaAlbum);
        }

    }
}
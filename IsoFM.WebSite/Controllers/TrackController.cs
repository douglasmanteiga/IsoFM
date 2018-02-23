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
    public class TrackController : Controller
    {
        BandRepository _bandRepository = new BandRepository();
        // GET: Track
        [OutputCache(Duration = 600, VaryByParam = "idAlbum")]
        public ActionResult DetailsAlbum(string idBand, string idAlbum)
        {

            if (idBand == null || string.IsNullOrEmpty(idBand) == true || idAlbum == null || string.IsNullOrEmpty(idAlbum) == true)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var bandFull = _bandRepository.ObterFull();
            var albumDetais = bandFull.Where(b => b.Id == idBand).FirstOrDefault().AlbumList;
            var album = albumDetais.FirstOrDefault().Where(a => a.Id == idAlbum);

            var tracksDetais = albumDetais.FirstOrDefault().Where(t => t.Id == idAlbum).FirstOrDefault().Tracks;

            List<Track> listaTrack = new List<Track>();

            foreach (var item in tracksDetais)
            {
                listaTrack.Add(item);
            }

            var viewModel = Mapper.Map<List<Track>, List<TrackViewModel>>(listaTrack);

            return View(viewModel);
        }
    }
}
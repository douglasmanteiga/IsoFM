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
        [OutputCache(Duration = 600, VaryByParam = "*")]
        public ActionResult Details(string idBand, string idAlbum)
        {

            if (idBand == null || string.IsNullOrEmpty(idBand) == true || idAlbum == null || string.IsNullOrEmpty(idAlbum) == true)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var bandFull = _bandRepository.ObterFull();
            var albumDetais = bandFull.Where(b => b.Id == idBand).FirstOrDefault().AlbumList;

            //Não consegue encontrar o album...>
            //var album = from Album p in albumDetais where p.Id == idBand select p;
            //var album = albumDetais.First().Where(a => a.Id == idAlbum);

            var album = new Album();
            foreach (var item in albumDetais)
            {
                if (item[0].Id == idAlbum)
                {
                    album = item[0];
                    break;
                }
            }

            List<Track> listaTrack = new List<Track>();

            if (string.IsNullOrEmpty(album.Id) == false)
            {
                listaTrack = album.Tracks.ToList<Track>();
            }

            var viewModel = Mapper.Map<List<Track>, List<TrackViewModel>>(listaTrack);

            return View(viewModel);
        }
    }
}
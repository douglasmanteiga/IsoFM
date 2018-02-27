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
        [OutputCache(Duration = 600, VaryByParam = "*")]
        public ActionResult Details(string id) /*string idBand, string idAlbum*/
        {

            AlbumViewModel album = null;

            foreach(BandViewModel banda in Discografia.BandCollection)
            {
                foreach(AlbumViewModel[] item in banda.AlbumList)
                {
                    foreach(var alb in item)
                    {
                        if(alb.Id == id)
                        {
                            album = alb;
                            break;
                        }
                    }

                    if (album != null) break;
                }
                if (album != null) break;
            }

            return View(album.Tracks);
        }
    }
}
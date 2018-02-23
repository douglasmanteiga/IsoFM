using AutoMapper;
using IsoFM.Domain.Entities;
using IsoFM.Infra.Reporitory;
using IsoFM.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IsoFM.WebSite.Controllers
{
    public class AlbumController : Controller
    {
        AlbumRepository _albumRepository = new AlbumRepository();
        // GET: Album
        [OutputCache(Duration = 600, VaryByParam = "none")]
        public ActionResult Index()
        {
            var viewModel = Mapper.Map<List<Album>, List<AlbumViewModel>>(_albumRepository.Obter());

            return View(viewModel);
        }
        
        //Não implementei a busca por ID porque não existe na API
    }
}
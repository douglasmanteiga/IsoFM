using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsoFM.WebSite.Models
{
    public class BandViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public string Biography { get; set; }
        public int NumPlays { get; set; }
        public string[] Albums { get; set; }
        public AlbumViewModel[][] AlbumList { get; set; }

    }
}
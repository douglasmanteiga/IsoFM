using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsoFM.WebSite.Models
{
    public class AlbumViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Band { get; set; }
        public TrackViewModel[] Tracks { get; set; }
    }
}
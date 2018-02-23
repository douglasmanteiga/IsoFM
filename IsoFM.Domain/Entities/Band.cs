using IsoFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoFM.Domain
{
    public class Band
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public string Biography { get; set; }
        public int NumPlays { get; set; }
        public string[] Albums { get; set; }
        public Album[][] AlbumList { get; set; }


    }
}

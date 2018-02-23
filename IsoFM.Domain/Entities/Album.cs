using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoFM.Domain.Entities
{
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Band { get; set; }
        public Track[] Tracks { get; set; }
    }
}

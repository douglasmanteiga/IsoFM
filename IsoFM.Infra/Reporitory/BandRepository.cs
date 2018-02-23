using IsoFM.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsoFM.Domain;
using IsoFM.Common;
using IsoFM.Domain.Entities;

namespace IsoFM.Infra.Reporitory
{
    public class BandRepository : IBandRepository
    {
        public List<Band> ObterFull()
        {
            ConsumirApi<Band> consumirApi = new ConsumirApi<Band>();

            return consumirApi.ResponseList("https://iws-recruiting-bands.herokuapp.com/api/", "full");
        }

        public List<Band> Obter()
        {
            ConsumirApi<Band> consumirApi = new ConsumirApi<Band>();

            return consumirApi.ResponseList("https://iws-recruiting-bands.herokuapp.com/api/", "bands");
        }

        public Band ObterPorId(string id)
        {
            ConsumirApi<Band> consumirApi = new ConsumirApi<Band>();

            return consumirApi.Response("https://iws-recruiting-bands.herokuapp.com/api/", "bands/" + id);
        }

    }
}

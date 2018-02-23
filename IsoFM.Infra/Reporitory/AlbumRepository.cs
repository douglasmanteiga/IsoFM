using IsoFM.Domain.Repositories;
using System.Collections.Generic;
using IsoFM.Domain.Entities;
using IsoFM.Common;

namespace IsoFM.Infra.Reporitory
{
    public class AlbumRepository : IAlbumRepository
    {
        public List<Album> Obter()
        {
            ConsumirApi<Album> consumirApi = new ConsumirApi<Album>();

            return consumirApi.ResponseList("https://iws-recruiting-bands.herokuapp.com/api/", "albums");
        }

        public Album ObterPorId(string id)
        {
            ConsumirApi<Album> consumirApi = new ConsumirApi<Album>();

            return consumirApi.Response("https://iws-recruiting-bands.herokuapp.com/api/", "albums/" + id);
        }        
    }
}

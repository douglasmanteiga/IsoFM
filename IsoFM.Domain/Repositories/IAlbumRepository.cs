using IsoFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoFM.Domain.Repositories
{
    public interface IAlbumRepository
    {
        List<Album> Obter();
        Album ObterPorId(string id);
    }
}

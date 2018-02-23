using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoFM.Domain.Repositories
{
    public interface IBandRepository
    {
        List<Band> Obter();
        Band ObterPorId(string id);
    }
}

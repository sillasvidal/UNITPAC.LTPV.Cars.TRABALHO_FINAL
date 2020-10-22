using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.DominioCars.CarsRoot;

namespace UNITPAC.LTPV.Infra.Interfaces
{
    public interface ICarsRepository
    {
        List<Carro> ObterTodos();
    }
}

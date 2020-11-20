using System.Collections.Generic;
using UNITPAC.LTPV.DominioCars.CarsRoot;

namespace UNITPAC.LTPV.Infra.Interfaces
{
    public interface ICarsRepository
    {
        List<Carro> ObterTodos();

        void Adicionar(Carro model);

        void Atualizar(Carro model);

        void Excluir(int id);

        Carro ObterPorId(int id);
    }
}

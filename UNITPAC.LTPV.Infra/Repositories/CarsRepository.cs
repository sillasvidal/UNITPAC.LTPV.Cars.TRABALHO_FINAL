using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UNITPAC.LTPV.DominioCars.CarsRoot;
using UNITPAC.LTPV.Infra.Context;
using UNITPAC.LTPV.Infra.Interfaces;

namespace UNITPAC.LTPV.Infra.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private LTPVContext _context;

        public CarsRepository()
        {
            _context = new LTPVContext();
        }

 
        public List<Carro> ObterTodos()
        {
            return _context.Carros.ToList();
        }

        public void Adicionar(Carro model)
        {
            _context.Carros.Add(model);
            _context.SaveChanges();
        }

        public void Atualizar(Carro model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            Carro model = _context.Carros.Where(a => a.ID == id).First();

            _context.Carros.Remove(model);

            _context.SaveChanges();
        }

        public Carro ObterPorId(int id)
        {
            return _context.Carros.Where(a => a.ID == id).AsNoTracking().First();
        }
    }
}

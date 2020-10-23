using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.DominioCars.CarsRoot;
using UNITPAC.LTPV.Infra.Interfaces;

namespace UNITPAC.LTPV.Infra.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private List<Carro> _carros;

        public CarsRepository()
        {
            _carros = new List<Carro>();
           
            _carros.Add(new Carro()
            {
                ID = 1,
                Modelo = "Corolla",
                Marca = "Toyota",
                Ano = 2012,
                Km = 80000,
                Preco = 45000
            });

            _carros.Add(new Carro()
            {
                ID = 2,
                Modelo = "Civic",
                Marca = "Honda",
                Ano = 2014,
                Km = 75000,
                Preco = 52000
            });

            _carros.Add(new Carro()
            {
                ID = 3,
                Modelo = "320i",
                Marca = "BMW",
                Ano = 2015,
                Km = 50000,
                Preco = 220000
            });

            _carros.Add(new Carro()
            {
                ID = 4,
                Modelo = "Panamera",
                Marca = "Porshe",
                Ano = 2020,
                Km = 0,
                Preco = 1500000
            });            
        }

        public void cadastrarCarro(string modelo, string marca, int ano, double km, double preco)
        {
            _carros.Add(new Carro()
            {
                ID = 5,
                Modelo = modelo,
                Marca = marca,
                Ano = ano,
                Km = km,
                Preco = preco
            });
        }

        public List<Carro> ObterTodos()
        {
            return _carros;
        }
    }
}

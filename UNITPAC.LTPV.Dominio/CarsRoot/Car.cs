using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITPAC.LTPV.Dominio
{
    public class Car
    {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public int Km { get; set; }
        public decimal Preco { get; set; }
    }
}

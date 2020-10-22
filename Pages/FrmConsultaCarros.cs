using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.DominioCars.CarsRoot;
using UNITPAC.LTPV.Infra.Interfaces;

namespace UNITPAC.LTPV.Cars.Pages
{
    public partial class FrmConsultaCarros : Form
    {
        private ICarsRepository _repository;
        public FrmConsultaCarros()
        {
            InitializeComponent();
            _repository = Program.container.GetInstance<ICarsRepository>();

            List<Carro> registros = _repository.ObterTodos();

            dataGridView1.DataSource = registros;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Aplicacao.Interfaces;
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
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            GridCarros.DataSource = _repository.ObterTodos();
        }

        void abrirFormulario(Form frm, bool permitirAbrirNovamente = false)
        {
            FormCollection fc = Application.OpenForms;

            if (!permitirAbrirNovamente)
            {
                foreach (Form item in fc)
                {
                    if (item.Name == frm.Name)
                    {
                        MessageBox.Show(this, "Este formulário já está aberto.", "Alerta", MessageBoxButtons.OK);
                        return;
                    }
                }
            }


            frm.Show();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (GridCarros.Rows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(GridCarros.SelectedRows[0].Cells[ColumnId.Index].Value);

            Carro model = _repository.ObterPorId(id);

            FrmAtualizaCarros frm = new FrmAtualizaCarros(model);

            this.Close();
            frm.Show();
        }

        private void GridCarros_DoubleClick(object sender, EventArgs e)
        {
            if (GridCarros.Rows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(GridCarros.SelectedRows[0].Cells[ColumnId.Index].Value);

            Carro model = _repository.ObterPorId(id);

            FrmAtualizaCarros frm = new FrmAtualizaCarros(model);


            this.Close();
            frm.Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (GridCarros.Rows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(GridCarros.SelectedRows[0].Cells[ColumnId.Index].Value);

            var resultado = MessageBox.Show(this, "Deseja realmente excluir o carro " + id + " ?", "LTPV", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.No)
            {
                return;
            }

            ICarroService service = Program.container.GetInstance<ICarroService>();

            if (service.Excluir(id))
            {
                PreencherGrid();
                MessageBox.Show(this, "Carro excluído com sucesso.", "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPreencherGrid_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void GridCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace UNITPAC.LTPV.Cars.Pages
{
    public partial class FrmAtualizaCarros : Form
    {
        public FrmAtualizaCarros(Carro model)
        {
            InitializeComponent();
            TxbID.Text = Convert.ToString(model.ID);
            TxbModelo.Text = model.Modelo;
            TxbMarca.Text = model.Marca;
            TxbAno.Text = Convert.ToString(model.Ano);
            TxbKm.Text = Convert.ToString(model.Km);
            TxbPreco.Text = Convert.ToString(model.Preco);

            TxbModelo.Focus();
        }
        private Carro MapearDominio()
        {
            Carro model = new Carro();

            model.Modelo = TxbModelo.Text;
            model.Marca = TxbMarca.Text;

            if (!string.IsNullOrEmpty(TxbID.Text))
            {
                model.ID = Convert.ToInt32(TxbID.Text);
            }

            if (string.IsNullOrEmpty(TxbAno.Text.Replace(" ", "")))
            {
                model.Ano = DateTime.Now.Year + 1;
            }
            else
            {
                model.Ano = Convert.ToInt32(TxbAno.Text);
            }

            if (string.IsNullOrEmpty(TxbKm.Text.Replace(" ", "")))
            {
                model.Km = -1;
            }
            else
            {
                model.Km = Convert.ToDouble(TxbKm.Text);
            }

            if (string.IsNullOrEmpty(TxbPreco.Text.Replace(" ", "")))
            {
                model.Preco = -1;
            }
            else
            {
                model.Preco = Convert.ToDouble(TxbPreco.Text);
            }

            return model;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Carro model = MapearDominio();

            ICarroService service = Program.container.GetInstance<ICarroService>();

            if (service.Atualizar(model))
            {
                MessageBox.Show(this, "Carro Atualizado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                FrmConsultaCarros frm = new FrmConsultaCarros();
                frm.Show();
            }
            else
            {
                TxbModelo.Focus();

                MessageBox.Show(this, "Não foi possível atualizar o carro. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmConsultaCarros frm = new FrmConsultaCarros();
            frm.Show();
        }
    }
}

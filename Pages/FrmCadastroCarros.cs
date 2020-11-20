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
using UNITPAC.LTPV.Infra.Repositories;

namespace UNITPAC.LTPV.Cars.Pages
{
    public partial class FrmCadastroCarros : Form
    {
        private ICarsRepository _repositorio;

        public FrmCadastroCarros()
        {
            InitializeComponent();
            _repositorio = Program.container.GetInstance<ICarsRepository>();
        }

        private void LbTitle_Click(object sender, EventArgs e)
        {

        }

        private Carro MapearDominio()
        {
            Carro model = new Carro();

            model.Modelo = TxbModelo.Text;
            model.Marca = TxbMarca.Text;

            if (string.IsNullOrEmpty(TxbAno.Text.Replace(" ", "")))
            {
                model.Ano = DateTime.Now.Year + 1;
            }else
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Carro model = MapearDominio();

            ICarroService service = Program.container.GetInstance<ICarroService>();

            if(service.Adicionar(model))
            {
                MessageBox.Show(this, "Carro Cadastrado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparComponentes();

                TxbModelo.Focus();
            }
            else
            {
                TxbModelo.Focus();

                MessageBox.Show(this, "Não foi possível adicionar o carro. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparComponentes()
        {
            TxbModelo.Text = string.Empty;
            TxbMarca.Text = string.Empty;
            TxbAno.Text = string.Empty;
            TxbKm.Text = string.Empty;
            TxbPreco.Text = string.Empty;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

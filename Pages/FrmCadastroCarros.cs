using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Infra.Repositories;

namespace UNITPAC.LTPV.Cars.Pages
{
    public partial class FrmCadastroCarros : Form
    {
        public FrmCadastroCarros()
        {
            InitializeComponent();
        }

        private void LbTitle_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CarsRepository carros = new CarsRepository();

            var modelo = TxbModelo.Text;
            var marca = TxbMarca.Text;
            var ano = Convert.ToInt32(TxbAno.Text);
            var km = Convert.ToDouble(TxbKm.Text);
            var preco = Convert.ToDouble(TxbPreco.Text);

            carros.cadastrarCarro(modelo, marca, ano, km, preco);
            MessageBox.Show("Carro Cadastrado com sucesso.", "Confirmação");
        }
    }
}

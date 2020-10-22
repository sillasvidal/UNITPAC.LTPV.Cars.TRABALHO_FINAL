using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Cars.Pages;

namespace UNITPAC.LTPV.Cars
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        void abrirFormulario(Form frm, bool permitirAbrirNovamente = false)
        {
            FormCollection fc = Application.OpenForms;

            if (!permitirAbrirNovamente)
            {
                foreach(Form item in fc)
                {
                    if(item.Name == frm.Name)
                    {
                        MessageBox.Show(this, "Este formulário já está aberto.", "Alerta", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCarros frm = new FrmCadastroCarros();
            abrirFormulario(frm);
        }

        private void carrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCarros frm = new FrmConsultaCarros();
            abrirFormulario(frm);
        }
    }
}

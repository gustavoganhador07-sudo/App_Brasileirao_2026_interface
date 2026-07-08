using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaBrasileirao
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmTelaConsultar consultar = new frmTelaConsultar();
            consultar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizartimes atualizar = new Atualizartimes();
            atualizar.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Projetos.View
{
    public partial class ucCadClientes : UserControl
    {
        public ucCadClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.CadClientes cad = new Controller.CadClientes();

            cad.inserirDados(txtNomeCli.Text,
                             txtCpfCli.Text,
                             txtRgCli.Text,
                             txtDataCad.Text,
                             txtDataNasc.Text,
                             txtTel1.Text,
                             txtTel2.Text) ;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Form form = new frmBuscaClientes();
            form.Show();
        }
    }
}

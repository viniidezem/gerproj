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
            txtCodCli.Enabled   = false;
            txtNomeCli.Enabled  = false;
            txtCpfCli.Enabled   = false;
            txtRgCli.Enabled    = false;
            txtDataCad.Enabled  = false;
            txtDataNasc.Enabled = false;
            txtTel1.Enabled     = false;
            txtTel2.Enabled     = false;

            btnInserir.Visible  = false;
            btnSalvar.Visible   = false;
            btnCancelar.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Controller.CadClientes cad = new Controller.CadClientes();

            cad.inserirDados(txtNomeCli.Text,
                             txtCpfCli.Text,
                             txtRgCli.Text,
                             txtDataCad.Text,
                             txtDataNasc.Text,
                             txtTel1.Text,
                             txtTel2.Text);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Form form = new frmBuscaClientes(this);
            form.Show();
        }

        private void txtTel1_Leave(object sender, EventArgs e)
        {
            if (txtTel1.TextLength == 15)
            {
                txtTel1.Mask = "(99) 00000-0000";
            }
            else
            {
                txtTel1.Mask = "(99) 0000-0000";
            }
        }

        private void txtTel1_Enter(object sender, EventArgs e)
        {
            txtTel1.Mask = "(99) 00000-0000";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Visible = false;
            btnInserir.Visible = true;

            txtCodCli.Enabled = false;
            txtNomeCli.Enabled = true;
            txtCpfCli.Enabled = true;
            txtRgCli.Enabled = true;
            txtDataCad.Enabled = true;
            txtDataNasc.Enabled = true;
            txtTel1.Enabled = true;
            txtTel2.Enabled = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Controller.CadClientes cad = new Controller.CadClientes();

            cad.atualizarDados(txtNomeCli.Text,
                 txtCpfCli.Text,
                 txtRgCli.Text,
                 txtDataCad.Text,
                 txtDataNasc.Text,
                 txtTel1.Text,
                 txtTel2.Text,
                 txtCodCli.Text);
        }
    }
}

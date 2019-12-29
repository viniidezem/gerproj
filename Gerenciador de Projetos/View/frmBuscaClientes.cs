using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Projetos.View
{
    public partial class frmBuscaClientes : Form
    {
        ucCadClientes uc;
        public frmBuscaClientes(ucCadClientes ucCad)
        {
            InitializeComponent();
            uc = ucCad;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Model.ConexaoDAO conexao = new Model.ConexaoDAO();

            conexao.OpenConection();
            
            dataGridView1.DataSource = conexao.ShowDataInGridView("SELECT * FROM TbClientes where nomcli " +
                                                                  "like ('%"+textBox1.Text+"%');");

            conexao.CloseConnection();
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentRow.Index;
            uc.txtCodCli.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            uc.txtNomeCli.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            uc.txtCpfCli.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            uc.txtRgCli.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            //uc.txtDataCad.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            uc.txtDataNasc.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            uc.txtTel1.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            uc.txtTel2.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();

            this.Dispose();
        }
    }
}

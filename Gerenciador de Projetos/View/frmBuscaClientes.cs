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
        public frmBuscaClientes()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Model.ConexaoDAO conexao = new Model.ConexaoDAO();

            conexao.OpenConection();
            
            dataGridView1.DataSource = conexao.ShowDataInGridView("SELECT * FROM TbClientes where nomcli " +
                                                                  "like ('%"+textBox1.Text+"%');");

            conexao.CloseConnection();
        }
    }
}

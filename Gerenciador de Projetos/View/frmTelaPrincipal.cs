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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }


        public void AddNewTab(string title, System.Windows.Forms.Control userControl)
        {
            
            TabPage myTabPage = new TabPage(title);//Create new tabpage
            myTabPage.Controls.Add(userControl);
            tabControl1.TabPages.Add(myTabPage);
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucCadClientes newUc = new ucCadClientes();
            newUc.Dock = DockStyle.Fill;
            AddNewTab("Cadastro Clientes", newUc);

        }
    }
}

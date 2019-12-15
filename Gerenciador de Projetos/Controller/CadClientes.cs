using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gerenciador_de_Projetos.Controller
{
    class CadClientes
    {

        public void inserirDados(string nome, string cpf, string rg, string datacad, string datanasc,
            string tel1, string tel2)
        {

            Model.ConexaoDAO conexao = new Model.ConexaoDAO();
            conexao.OpenConection();

            string query = "INSERT INTO TbClientes (nomcli,cpf,rg,datacadastro,datanascimento,tel1,tel2) " +
                           "VALUES ('" + nome + "','" 
                           + cpf + "','" 
                           + rg + "','" 
                           + datacad + "','" 
                           + datanasc + "','" 
                           + tel1 + "','" 
                           + tel2 + "');";

            conexao.ExecuteQueries(query);
            conexao.CloseConnection();
        }
    }
}

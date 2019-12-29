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

        public void atualizarDados(string nome, string cpf, string rg, string datacad, string datanasc,
            string tel1, string tel2, string codcli)
        {
            Model.ConexaoDAO conexao = new Model.ConexaoDAO();
            conexao.OpenConection();

            string query = "UPDATE TbClientes SET nomcli         = '" + nome + "' , " +
                                                " cpf            = '" + cpf + "'," +
                                                " rg             = '" + rg + "', " +
                                                " datacadastro   = '" + datacad + "', " +
                                                " datanascimento = '" + datanasc + "', " +
                                                " tel1           = '" + tel1 + "', " +
                                                " tel2           = '" + tel2 + "'" +
                                                " WHERE " +
                                                " id_cliente         = '" + codcli + "';";

            conexao.ExecuteQueries(query);
            conexao.CloseConnection();

        }
    }
}

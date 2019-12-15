using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gerenciador_de_Projetos.Model
{
    public class ConexaoDAO
    {
        string ConnectionString = "Server=localhost;Database=gerproj;User Id=sa;" +
                         "Password=sa@2017;";

        /*    public static void Connect()
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    System.Windows.Forms.MessageBox.Show("Conectou");
                }
            }
        */

        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            System.Windows.Forms.MessageBox.Show("Conectou");
        }


        public void CloseConnection()
        {
            con.Close();
            con.Dispose();
            System.Windows.Forms.MessageBox.Show("Fechou");
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }


}


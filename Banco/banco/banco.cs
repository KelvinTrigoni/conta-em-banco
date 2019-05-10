using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    class banco
    {
        SqlConnection com = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=banco;Data Source=CELSO-MEGA\KELVIN");

        SqlCommand cmd = null;


        public void comandosql(string Sql)
        {
            //abre a conexão
            com.Open();

            //Inseri o comando SQL e atribuir a conexão do banco
            cmd = new SqlCommand(Sql, com);

            //executa o comando
            cmd.ExecuteNonQuery();

            //fecha a conexão
            com.Close();


        }


        public void consultar(DataGridView Dgv, string Sql)
        {
            com.Open();
            cmd = new SqlCommand(Sql, com);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Dgv.DataSource = dt;
            com.Close();
        }
    }
}


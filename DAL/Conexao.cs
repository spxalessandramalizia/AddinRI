using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Conexao
    {
        private SqlConnection Conn = new SqlConnection(@"Data Source=EQNSQL02\HOMOLOGASPXBANCO;Initial Catalog=RIMovimentos;Integrated Security=True");

        public SqlConnection AbrirConexao()
        {
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            return Conn;
        }

        public SqlConnection FecharConexao()
        {
            if (Conn.State == ConnectionState.Open) { Conn.Close(); }
            return Conn;
        }
    }
}

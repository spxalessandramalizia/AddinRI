using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA_Alocador
    {
        private Conexao Conexao = new Conexao();

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT * FROM Alocadores";

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

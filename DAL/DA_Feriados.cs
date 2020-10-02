using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA_Feriados
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(DateTime Data, string Nome)
        {
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "INSERT INTO Feriados (DATA, FERIADO) VALUES (@DATA, @FERIADO)";

            Comando.Parameters.AddWithValue("@DATA", Data);
            Comando.Parameters.AddWithValue("@FERIADO", Nome);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable Dados()
        {
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Read;
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "SELECT * FROM Feriados";

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
            return Table;
        }

    }
}

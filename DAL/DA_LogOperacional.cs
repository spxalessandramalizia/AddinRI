using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DAL
{
    public class DA_LogOperacional
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(DateTime DATA, DateTime HORA, string SISTEMA, string USUARIO, string DESCRICAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "INSERT INTO LogsOperacionais VALUES (@DATA,@HORA,@SISTEMA,@USUARIO,@DESCRICAO)";

            Comando.Parameters.AddWithValue("@DATA", DATA);
            Comando.Parameters.AddWithValue("@HORA", HORA);
            Comando.Parameters.AddWithValue("@SISTEMA", SISTEMA);
            Comando.Parameters.AddWithValue("@USUARIO", USUARIO);
            Comando.Parameters.AddWithValue("@DESCRICAO", DESCRICAO);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM LogsOperacionais";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorData(DateTime DATA)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM LogsOperacionais WHERE DATA = @DATA";
            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@DATA", DATA);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DateTime UltimoLog(string DESCRICAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "SELECT Max(LogsOperacionais.DATA) FROM LogsOperacionais WHERE DESCRICAO = @DESCRICAO";          
            Comando.Parameters.AddWithValue("@DESCRICAO", DESCRICAO);

            try { return Convert.ToDateTime(Comando.ExecuteScalar()); }
            catch { return DateTime.Today.AddDays(-1); }
        }
    }
}

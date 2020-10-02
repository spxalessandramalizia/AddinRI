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
    public class DA_RegistroAplica
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CPFCNPJ, string NOME, DateTime HORA, decimal VALOR, long CODFUND)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "INSERT INTO RegistrosAplica VALUES (@CPFCNPJ,@NOME,@HORA,@VALOR,@CODFUND)";

            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Comando.Parameters.AddWithValue("@NOME", NOME);
            Comando.Parameters.AddWithValue("@HORA", HORA);
            Comando.Parameters.AddWithValue("@VALOR", VALOR);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Limpar()
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "DELETE FROM RegistrosAplica";

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosCompletos()
        {
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Read;
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM RegistrosAplica";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

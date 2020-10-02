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
    public class DA_ContaCredito
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CODCOT, string TIPOCONTA, long CETIP, int BANCO, int AGENCIA, long CONTA, int DIGITO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "INSERT INTO ContasCredito VALUES (@CODCOT,@TIPOCONTA,@CETIP,@BANCO,@AGENCIA,@CONTA,@DIGITO)";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@TIPOCONTA", TIPOCONTA);
            Comando.Parameters.AddWithValue("@CETIP", CETIP);
            Comando.Parameters.AddWithValue("@BANCO", BANCO);
            Comando.Parameters.AddWithValue("@AGENCIA", AGENCIA);
            Comando.Parameters.AddWithValue("@CONTA", CONTA);
            Comando.Parameters.AddWithValue("@DIGITO", DIGITO);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosPorCODCOT(long CODCOT)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT ContasCredito.* " +
                                  "FROM ContasCredito " +
                                  "WHERE(((ContasCredito.CODCOT) = @CODCOT))";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCPFCNPJ(long CPFCNPJ)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT ContasCredito.* " +
                                  "FROM ContasCredito INNER JOIN Cotistas ON ContasCredito.CODCOT = Cotistas.CODCOT " +
                                  "WHERE(((Cotistas.CPFCNPJ) =@CPFCNPJ))";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

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
    public class DA_Cotista
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CODCOT, string NOME, long CPFCNPJ, long CODDIST, long CODALOCADOR, DateTime VENCIMENTO)
        {
            SqlCommand Comando = new SqlCommand
            {
                Connection = Conexao.AbrirConexao(),
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO Cotistas VALUES (@CODCOT,@NOME,@CPFCNPJ,@CODDIST,@CODALOCADOR,@VENCIMENTO)"
            };

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@NOME", NOME);
            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Comando.Parameters.AddWithValue("@CODDIST", CODDIST);
            Comando.Parameters.AddWithValue("@CODALOCADOR", CODALOCADOR);
            Comando.Parameters.AddWithValue("@VENCIMENTO", VENCIMENTO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Editar(long CODCOT, string NOME, long CPFCNPJ, long CODDIST, long CODALOCADOR, DateTime VENCIMENTO)
        {
            SqlCommand Comando = new SqlCommand
            {
                Connection = Conexao.AbrirConexao(),
                CommandType = CommandType.Text,
                CommandText = "UPDATE Cotistas SET NOME = @NOME, CODDIST = @CODDIST, CODALOCADOR = @CODALOCADOR, VENCIMENTO = @VENCIMENTO WHERE CODCOT = @CODCOT"
            };

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@NOME", NOME);
            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Comando.Parameters.AddWithValue("@CODDIST", CODDIST);
            Comando.Parameters.AddWithValue("@CODALOCADOR", CODALOCADOR);
            Comando.Parameters.AddWithValue("@VENCIMENTO", VENCIMENTO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Atualizar(long CODCOT, long CODALOCADOR)
        {
            SqlCommand Comando = new SqlCommand
            {
                Connection = Conexao.AbrirConexao(),
                CommandType = CommandType.Text,
                CommandText = "UPDATE Cotistas SET CODALOCADOR = @CODALOCADOR Where CODCOT = @CODCOT"
            };

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODALOCADOR", CODALOCADOR);


            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Cotistas";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCODCOT(long CODCOT)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Cotistas WHERE CODCOT = @CODCOT";
            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.CommandType = CommandType.Text;
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
            Comando.CommandText = "SELECT * FROM Cotistas WHERE CPFCNPJ = @CPFCNPJ";
            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCPFCNPJeSALDO(long CPFCNPJ, long CODFUND)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT Cotistas.* " +
                                  "FROM Cotistas INNER JOIN Saldos2 ON Cotistas.CODCOT = Saldos2.CODCOT " +
                                  "WHERE(((Cotistas.CPFCNPJ) = @CPFCNPJ) AND((Saldos2.CODFUND) = @CODFUND) AND((Saldos2.TIPOREGISTRO) = 'Total') AND((Saldos2.QNTCOTAS) > 0));";

            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

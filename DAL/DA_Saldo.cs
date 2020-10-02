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
    public class DA_Saldo
    {
        private Conexao Conexao = new Conexao();

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Saldos2";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCPFCNPJ(long CPFCNPJ)
        {
            DataTable Table = new DataTable();
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT Saldos2.* FROM Cotistas INNER JOIN Saldos2 ON Cotistas.CODCOT = Saldos2.CODCOT WHERE Cotistas.CPFCNPJ = @CPFCNPJ";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@CPFCNPJ", CPFCNPJ);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCODCOTeFUNDO(long CODCOT, long CODFUND)
        {
            DataTable Table = new DataTable();
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT Saldos2.* " +
                                  "FROM Saldos2 " +
                                  "WHERE(((Saldos2.TIPOREGISTRO) = 'Total') AND((Saldos2.CODCOT) = @CODCOT) AND((Saldos2.CODFUND) = @CODFUND));";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable CautelasPorCODCOTeFUNDO(long CODCOT, long CODFUND)
        {
            DataTable Table = new DataTable();
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT * FROM Saldos2 WHERE CODCOT = @CODCOT AND CODFUND = @CODFUND AND CAUTELA != 0";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorCAUTELA(long CAUTELA)
        {
            DataTable Table = new DataTable();
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT * FROM Saldos2 WHERE CAUTELA = @CAUTELA";

            Comando.Parameters.AddWithValue("@CAUTELA", CAUTELA);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
        public void Inserir(long CODCOT, long CODFUND, string TIPOREGISTRO, long CAUTELA, decimal QNTCOTAS, DateTime DTLANCT, decimal VLCOTAP)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "INSERT INTO Saldos2 (CODCOT, CODFUND, DTLANCT, VLCOTAP, TIPOREGISTRO, CAUTELA, QNTCOTAS) VALUES " +
                                  "(@CODCOT, @CODFUND, @DTLANCT, @VLCOTAP, @TIPOREGISTRO, @CAUTELA, @QNTCOTAS)";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@DTLANCT", DTLANCT);
            Comando.Parameters.AddWithValue("@VLCOTAP", VLCOTAP);
            Comando.Parameters.AddWithValue("@TIPOREGISTRO", TIPOREGISTRO);
            Comando.Parameters.AddWithValue("@CAUTELA", CAUTELA);
            Comando.Parameters.AddWithValue("@QNTCOTAS", QNTCOTAS);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Deletar()
        {
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "DELETE FROM Saldos2";

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void EditarSimples(long CODCOT, long CODFUND, string TIPOREGISTRO, long CAUTELA, decimal QNTCOTAS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Saldos2 " +
                                  "SET CODCOT = @CODCOT, " +
                                  "TIPOREGISTRO = @TIPOREGISTRO, " +
                                  "CODFUND = @CODFUND, " +
                                  "QNTCOTAS = @QNTCOTAS " +
                                  "WHERE CAUTELA = @CAUTELA";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@TIPOREGISTRO", TIPOREGISTRO);
            Comando.Parameters.AddWithValue("@QNTCOTAS", QNTCOTAS);
            Comando.Parameters.AddWithValue("@CAUTELA", CAUTELA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void EditarTotal(long CODCOT, long CODFUND, decimal QNTCOTAS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Saldos2 " +
                                  "SET QNTCOTAS = @QNTCOTAS " +
                                  "WHERE CODCOT = @CODCOT AND CODFUND = @CODFUND AND CAUTELA = 0";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@QNTCOTAS", QNTCOTAS);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void DeletarSimples(long CAUTELA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM Saldos2 WHERE CAUTELA = @CAUTELA";

            Comando.Parameters.AddWithValue("@CAUTELA", CAUTELA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void DeletarTotal(long CODCOT, long CODFUND)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM Saldos2 WHERE CODCOT = @CODCOT AND CODFUND = @CODFUND AND CAUTELA = 0";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }
    }
}

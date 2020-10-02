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
    public class DA_Boleta
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(string IDORDEM, long CODCOT, long CODFUND, string STATUS, DateTime SOLICITACAO, DateTime COTIZACAO, DateTime IMPACTO, string OPERACAO, decimal VALOR, string CONTA, long CAUTELA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "INSERT INTO Boletas (IDORDEM, CODCOT, CODFUND, STATUS, SOLICITACAO, COTIZACAO, IMPACTO, OPERACAO, VALOR, CONTA, CAUTELA) VALUES " +
                                  "(@IDORDEM, @CODCOT, @CODFUND, @STATUS, @SOLICITACAO, @COTIZACAO, @IMPACTO, @OPERACAO, @VALOR, @CONTA, @CAUTELA)";

            Comando.Parameters.AddWithValue("@IDORDEM", IDORDEM);
            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);
            Comando.Parameters.AddWithValue("@COTIZACAO", COTIZACAO);
            Comando.Parameters.AddWithValue("@IMPACTO", IMPACTO);
            Comando.Parameters.AddWithValue("@OPERACAO", OPERACAO);
            Comando.Parameters.AddWithValue("@VALOR", VALOR);
            Comando.Parameters.AddWithValue("@CONTA", CONTA);
            Comando.Parameters.AddWithValue("@CAUTELA", CAUTELA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Editar(long IDBOLETA, DateTime COTIZACAO, DateTime IMPACTO, string STATUS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Boletas SET COTIZACAO = @COTIZACAO, IMPACTO = @IMPACTO, STATUS = @STATUS WHERE IDBOLETA = @IDBOLETA";

            Comando.Parameters.AddWithValue("@COTIZACAO", COTIZACAO);
            Comando.Parameters.AddWithValue("@IMPACTO", IMPACTO);
            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Deletar(long IDBOLETA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.CommandType = CommandType.Text;
            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "DELETE FROM Boletas WHERE IDBOLETA = @IDBOLETA";
            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosDia(DateTime Dia)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;


            Comando.CommandText = "SELECT Boletas.*, FIQs.NOMEFANTASIA AS FUNDO, Cotistas.NOME, Cotistas.CPFCNPJ " +
                                  "FROM(Boletas INNER JOIN Cotistas ON Boletas.CODCOT = Cotistas.CODCOT) INNER JOIN FIQs ON Boletas.CODFUND = FIQs.CODFUND " +
                                  "WHERE(((Boletas.SOLICITACAO) = @SOLICITACAO))";

            Comando.Parameters.AddWithValue("@SOLICITACAO", Dia);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosZeragemDia(DateTime Dia)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;


            Comando.CommandText = "SELECT b.*, m.NOMEFANTASIA AS FUNDO, c.NOME, c.CPFCNPJ FROM Boletas b " +
                                  "JOIN Masters m ON b.CODFUND = m.CODFUND " +
                                  "JOIN Cotistas c ON b.CODCOT = c.CODCOT " +
                                  "WHERE b.SOLICITACAO = @SOLICITACAO";

            Comando.Parameters.AddWithValue("@SOLICITACAO", Dia);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosIDORDEM(string IDORDEM)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT b.*, f.NOMEFANTASIA AS FUNDO, c.NOME, c.CPFCNPJ " +
                                  "FROM Boletas b INNER JOIN Cotistas c ON b.CODCOT = c.CODCOT " +
                                  "INNER JOIN FIQs f ON b.CODFUND = f.CODFUND " +
                                  "WHERE b.IDORDEM = @IDORDEM " +
                                  "UNION " +
                                  "SELECT b.*, m.NOMEFANTASIA AS FUNDO, c.NOME, c.CPFCNPJ " +
                                  "FROM Boletas b INNER JOIN Cotistas c ON b.CODCOT = c.CODCOT " +
                                  "INNER JOIN Masters m ON b.CODFUND = m.CODFUND " +
                                  "WHERE b.IDORDEM = @IDORDEM";

            Comando.Parameters.AddWithValue("@IDORDEM", IDORDEM);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT Boletas.*, FIQs.NOMEFANTASIA AS FUNDO, Cotistas.NOME, Cotistas.CPFCNPJ " +
                                  "FROM(Boletas INNER JOIN Cotistas ON Boletas.CODCOT = Cotistas.CODCOT) INNER JOIN FIQs ON Boletas.CODFUND = FIQs.CODFUND";

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DataBoletaPorID(long IDBOLETA)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT b.*, f.NOMEFANTASIA AS FUNDO, c.NOME, c.CPFCNPJ " +
                                  "FROM Boletas b INNER JOIN Cotistas c ON b.CODCOT = c.CODCOT " +
                                  "INNER JOIN FIQs f ON b.CODFUND = f.CODFUND " +
                                  "WHERE b.IDBOLETA = @IDBOLETA " +
                                  "UNION " +
                                  "SELECT b.*, m.NOMEFANTASIA AS FUNDO, c.NOME, c.CPFCNPJ " +
                                  "FROM Boletas b INNER JOIN Cotistas c ON b.CODCOT = c.CODCOT " +
                                  "INNER JOIN Masters m ON b.CODFUND = m.CODFUND " +
                                  "WHERE b.IDBOLETA = @IDBOLETA";

            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public List<DateTime> DataSolicitacao()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT Boletas.SOLICITACAO FROM Boletas GROUP BY Boletas.SOLICITACAO ORDER BY Boletas.SOLICITACAO";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);
            Conexao.FecharConexao();

            List<DateTime> DataBoletas = new List<DateTime>();

            foreach (DataRow dr in Table.Rows)
            {
                DataBoletas.Add(Convert.ToDateTime(dr["SOLICITACAO"]));
            }
            return DataBoletas;
        }

    }
}

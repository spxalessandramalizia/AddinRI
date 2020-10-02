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
    public class DA_RegistroResgate
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CODCOT, long CODFUND, string OPERACAO, decimal VALOR, string CONTA, string STATUS, DateTime SOLICITACAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "INSERT INTO RegistrosResgate (IDBOLETA, CODCOT, CODFUND, OPERACAO, VALOR, CONTA, STATUS, SOLICITACAO) VALUES (@IDBOLETA, @CODCOT,@CODFUND,@OPERACAO,@VALOR,@CONTA,@STATUS,@SOLICITACAO)";

            Comando.Parameters.AddWithValue("@IDBOLETA", 0);
            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@OPERACAO", OPERACAO);
            Comando.Parameters.AddWithValue("@VALOR", VALOR);
            Comando.Parameters.AddWithValue("@CONTA", CONTA);
            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void EditarIDBOLETA(long IDBOLETA, string STATUS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "UPDATE RegistrosResgate SET STATUS = @STATUS WHERE IDBOLETA = @IDBOLETA";

            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void EditarIDREGISTRO(long IDREGISTRO, long IDBOLETA, string STATUS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE RegistrosResgate SET STATUS = @STATUS, IDBOLETA = @IDBOLETA WHERE IDREGISTRO = @IDREGISTRO";

            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);
            Comando.Parameters.AddWithValue("@IDREGISTRO", IDREGISTRO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void DeletarIDREGISTRO(long IDREGISTRO)
        {
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.Text;

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "DELETE FROM RegistrosResgate WHERE IDREGISTRO = @IDREGISTRO";

            Comando.Parameters.AddWithValue("@IDREGISTRO", IDREGISTRO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void DeletarIDBOLETA(long IDBOLETA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "DELETE FROM RegistrosResgate WHERE IDBOLETA = @IDBOLETA";

            Comando.Parameters.AddWithValue("@IDBOLETA", IDBOLETA);

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
            Comando.CommandText = "SELECT * FROM RegistrosResgate";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorData(DateTime Dia)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM RegistrosResgate WHERE SOLICITACAO = @SOLICITACAO";
            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@SOLICITACAO", Dia);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosDisplay(DateTime Dia)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT RegistrosResgate.IDREGISTRO As ID, RegistrosResgate.CODCOT, Cotistas.CPFCNPJ, Cotistas.NOME, FIQs.NOMEFANTASIA AS FUNDO, RegistrosResgate.OPERACAO AS OP, RegistrosResgate.VALOR, RegistrosResgate.CONTA, RegistrosResgate.STATUS " +
                                  "FROM FIQs INNER JOIN(Cotistas INNER JOIN RegistrosResgate ON Cotistas.CODCOT = RegistrosResgate.CODCOT) ON FIQs.CODFUND = RegistrosResgate.CODFUND " +
                                  "WHERE(((RegistrosResgate.SOLICITACAO) = @SOLICITACAO))";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@SOLICITACAO", Dia);
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
            Comando.CommandText = "SELECT RegistrosResgate.SOLICITACAO FROM RegistrosResgate GROUP BY RegistrosResgate.SOLICITACAO ORDER BY RegistrosResgate.SOLICITACAO";

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

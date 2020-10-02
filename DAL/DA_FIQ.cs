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
    public class DA_FIQ
    {
        private Conexao Conexao = new Conexao();
        public DataTable DadosPorCODFUND(long CODFUND)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM FIQs WHERE CODFUND = @CODFUND";

            Comando.CommandType = CommandType.Text;
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
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
            Comando.CommandText = "SELECT * FROM FIQs";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable AplicaPorFIQ(DateTime SOLICITACAO)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT FIQs.NOMEFANTASIA AS FIQ, Sum(Boletas.VALOR) AS TOTAL " +
                                  "FROM Boletas INNER JOIN FIQs ON Boletas.CODFUND = FIQs.CODFUND " +
                                  "WHERE(((Boletas.OPERACAO) = 'AP') AND((Boletas.SOLICITACAO) = @SOLICITACAO) AND(Not(Boletas.STATUS) = 'Cancelado')) " +
                                  "GROUP BY FIQs.NOMEFANTASIA " +
                                  "ORDER BY Sum(Boletas.VALOR) DESC";

            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

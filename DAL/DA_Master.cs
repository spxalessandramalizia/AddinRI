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
    public class DA_Master
    {
        private Conexao Conexao = new Conexao();

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Masters";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable AplicaPorMaster(DateTime SOLICITACAO)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT Masters.NOMEFANTASIA AS MASTER, Sum(Boletas.VALOR) AS TOTAL " +
                                  "FROM Masters INNER JOIN(Boletas INNER JOIN FIQs ON Boletas.CODFUND = FIQs.CODFUND) ON Masters.CODFUND = FIQs.CODMASTER " +
                                  "WHERE(((Boletas.OPERACAO) = 'AP') AND((Boletas.SOLICITACAO) = @SOLICITACAO) AND(Not(Boletas.STATUS) = 'Cancelado')) " +
                                  "GROUP BY Masters.NOMEFANTASIA " +
                                  "ORDER BY Sum(Boletas.VALOR) DESC";

            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
        public DataTable AplicaPorMasterIntrag(DateTime SOLICITACAO)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();

            Comando.CommandText = "SELECT Masters.NOMEFANTASIA AS MASTER, Sum(Boletas.VALOR) AS TOTAL " +
                                  "FROM Masters INNER JOIN(Boletas INNER JOIN FIQs ON Boletas.CODFUND = FIQs.CODFUND) ON Masters.CODFUND = FIQs.CODMASTER " +
                                  "WHERE(((Boletas.OPERACAO) = 'AP') AND((Boletas.SOLICITACAO) = @SOLICITACAO) AND(Not(Boletas.STATUS) = 'Cancelado')) " +
                                  "GROUP BY Masters.NOMEFANTASIA " +
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

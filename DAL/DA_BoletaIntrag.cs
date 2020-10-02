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
    public class DA_BoletaIntrag
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CODCOT, long CODFUND, DateTime COTIZACAO, DateTime IMPACTO, DateTime HORA, string OPERACAO, string TIPORESGATE, string TIPOLIQUIDA, decimal FINANCEIRO, decimal QUANTIDADE, string TIPOCONTA, long BANCO, string CONTA, string STATUS, string USUARIO, DateTime SOLICITACAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "INSERT INTO BoletasIntrag VALUES (@CODCOT,@CODFUND,@SOLICITACAO,@COTIZACAO,@IMPACTO,@HORA,@OPERACAO,@TIPORESGATE,@TIPOLIQUIDA,@FINANCEIRO,@QUANTIDADE,@TIPOCONTA,@BANCO,@CONTA,@STATUS,@USUARIO)";

            Comando.Parameters.AddWithValue("@CODCOT", CODCOT);
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);
            Comando.Parameters.AddWithValue("@COTIZACAO", COTIZACAO);
            Comando.Parameters.AddWithValue("@IMPACTO", IMPACTO);
            Comando.Parameters.AddWithValue("@HORA", HORA);
            Comando.Parameters.AddWithValue("@OPERACAO", OPERACAO);
            Comando.Parameters.AddWithValue("@TIPORESGATE", TIPORESGATE);
            Comando.Parameters.AddWithValue("@TIPOLIQUIDA", TIPOLIQUIDA);
            Comando.Parameters.AddWithValue("@FINANCEIRO", FINANCEIRO);
            Comando.Parameters.AddWithValue("@QUANTIDADE", QUANTIDADE);
            Comando.Parameters.AddWithValue("@TIPOCONTA", TIPOCONTA);
            Comando.Parameters.AddWithValue("@BANCO", BANCO);
            Comando.Parameters.AddWithValue("@CONTA", CONTA);
            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@USUARIO", USUARIO);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Limpar(DateTime SOLICITACAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "DELETE FROM BoletasIntrag WHERE SOLICITACAO = @SOLICITACAO";
            Comando.CommandType = CommandType.Text;

            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosDia(DateTime SOLICITACAO)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM BoletasIntrag WHERE SOLICITACAO = @SOLICITACAO";
            Comando.CommandType = CommandType.Text;

            Comando.Parameters.AddWithValue("@SOLICITACAO", SOLICITACAO);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

    }
}

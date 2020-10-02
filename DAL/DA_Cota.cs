using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA_Cota
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(long CODFUND, DateTime DATA, decimal COTA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "INSERT INTO Cotas (CODFUND, DATA, COTA) VALUES (@CODFUND, @DATA, @COTA)";

            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@DATA", DATA);
            Comando.Parameters.AddWithValue("@COTA", COTA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Editar(long CODFUND, DateTime DATA, decimal COTA)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Cotas SET COTA = @COTA WHERE CODFUND = @CODFUND AND DATA = @DATA";
        
            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@DATA", DATA);
            Comando.Parameters.AddWithValue("@COTA", COTA);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadoCota(long CODFUND, DateTime DATA)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT * FROM Cotas WHERE CODFUND = @CPDFUND AND DATA = @DATA";

            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);
            Comando.Parameters.AddWithValue("@DATA", DATA);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadoUltimaCota(long CODFUND)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();
        
            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
      
            Comando.CommandText = "SELECT * FROM Cotas WHERE CODFUND = @CODFUND AND DATA = (SELECT Max(Cotas.DATA) FROM Cotas WHERE CODFUND = @CODFUND)";

            Comando.Parameters.AddWithValue("@CODFUND", CODFUND);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosDia(DateTime DATA)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT * FROM Cotas WHERE DATA = @DATA";

            Comando.Parameters.AddWithValue("@DATA", DATA);
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorFundo(long CODFUND)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT * FROM Cotas WHERE CODFUND = @CPDFUND";

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
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT * FROM Cotas";

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

    }
}

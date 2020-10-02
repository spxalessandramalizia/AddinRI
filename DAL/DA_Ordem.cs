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
    public class DA_Ordem
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(string USUARIO, DateTime HORARIO, DateTime DATA, string DE, string ASSUNTO, string STATUS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO Ordens(USUARIO, HORARIO, DATA, DE, ASSUNTO, STATUS) VALUES (@USUARIO, @HORARIO, @DATA, @DE, @ASSUNTO, @STATUS)";

            Comando.Parameters.AddWithValue("@USUARIO", USUARIO);
            Comando.Parameters.AddWithValue("@HORARIO", HORARIO);
            Comando.Parameters.AddWithValue("@DATA", DATA);
            Comando.Parameters.AddWithValue("@DE", DE);
            Comando.Parameters.AddWithValue("@ASSUNTO", ASSUNTO);
            Comando.Parameters.AddWithValue("@STATUS", STATUS);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Editar(long IDORDEM, string STATUS)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "UPDATE Ordens SET STATUS = @STATUS Where IDORDEM = @IDORDEM";

            Comando.Parameters.AddWithValue("@STATUS", STATUS);
            Comando.Parameters.AddWithValue("@IDORDEM", IDORDEM);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Deletar(long IDORDEM)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "DELETE FROM Ordens WHERE IDORDEM = @IDORDEM";

            Comando.Parameters.AddWithValue("@IDORDEM", IDORDEM);

            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public long MaxID()
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT Max(Ordens.IDORDEM) AS MaxOfIDORDEM FROM Ordens";
            Comando.CommandType = CommandType.Text;

            try { return Convert.ToInt64(Comando.ExecuteScalar()); }
            catch { return 0; }
        }

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Ordens";

            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorDia(DateTime Dia)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "SELECT * FROM Ordens WHERE DATA = @DATA";
            Comando.Parameters.AddWithValue("@DATA", Dia);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

        public DataTable DadosPorIDORDEM(long IDORDEM)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandText = "SELECT * FROM Ordens WHERE IDORDEM = @IDORDEM";
            Comando.Parameters.AddWithValue("@IDORDEM", IDORDEM);
            Comando.CommandType = CommandType.Text;
            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }
    }
}

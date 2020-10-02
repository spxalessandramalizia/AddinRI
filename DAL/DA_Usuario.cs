using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA_Usuario
    {
        private Conexao Conexao = new Conexao();

        public void Inserir(string WINDOWSNAME, string USUARIO, string SENHA, DateTime DTATUALIZACAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "INSERT INTO Usuarios (WINDOWSNAME, USUARIO, SENHA, DTATUALIZACAO) " +
                                  "VALUES (@WINDOWSNAME, @USUARIO, @SENHA, @DTATUALIZACAO)";

            Comando.Parameters.AddWithValue("@WINDOWSNAME", WINDOWSNAME);
            Comando.Parameters.AddWithValue("@USUARIO", USUARIO);
            Comando.Parameters.AddWithValue("@SENHA", SENHA);
            Comando.Parameters.AddWithValue("@DTATUALIZACAO", DTATUALIZACAO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Editar(string WINDOWSNAME, string USUARIO, string SENHA, DateTime DTATUALIZACAO)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Usuarios " +
                                 "SET USUARIO = @USUARIO, SENHA = @SENHA, DTATUALIZACAO = @DTATUALIZACAO " +
                                 "WHERE WINDOWSNAME = @WINDOWSNAME";

            Comando.Parameters.AddWithValue("@WINDOWSNAME", WINDOWSNAME);
            Comando.Parameters.AddWithValue("@USUARIO", USUARIO);
            Comando.Parameters.AddWithValue("@SENHA", SENHA);
            Comando.Parameters.AddWithValue("@DTATUALIZACAO", DTATUALIZACAO);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public void Resetar(string WINDOWSNAME)
        {
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "UPDATE Usuarios " +
                                 "SET USUARIO = NULL, SENHA = NULL " +
                                 "WHERE WINDOWSNAME = @WINDOWSNAME";

            Comando.Parameters.AddWithValue("@WINDOWSNAME", WINDOWSNAME);

            Comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public DataTable DadosCompletos()
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "SELECT * FROM Usuarios";

            DataTable dTable = new DataTable();
            Read = Comando.ExecuteReader();
            dTable.Load(Read);

            Conexao.FecharConexao();

            return dTable;
        }

        public DataTable DadosNome(string WINDOWSNAME)
        {
            SqlDataReader Read;
            SqlCommand Comando = new SqlCommand();
            DataTable Table = new DataTable();

            Comando.Connection = Conexao.AbrirConexao();
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "SELECT * " +
                                  "FROM Usuarios " +
                                  "WHERE WINDOWSNAME = @WINDOWSNAME";

            Comando.Parameters.AddWithValue("@WINDOWSNAME", WINDOWSNAME);

            Read = Comando.ExecuteReader();
            Table.Load(Read);

            Conexao.FecharConexao();
            return Table;
        }

    }
}

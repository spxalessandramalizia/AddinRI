using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DAL
{
    public class DA_LogErro
    {
        public void Inserir(DateTime DATA, DateTime HORA, string USUARIO, string SISTEMA, string DESCRICAO, string local)
        {
            string Line = DATA.ToShortDateString() + ";" + HORA.ToShortTimeString() + ";" + USUARIO + ";" + SISTEMA + ";" + DESCRICAO + ";";
            //StreamWriter Arquivo = new StreamWriter(File.Open(local, FileMode.Append), Encoding.Default);
            //Arquivo.WriteLine(Line);
            Console.WriteLine(Line);
        }

        public DataTable DadosPorData(DateTime DATA, string Local)
        {
            DataTable Dados = new DataTable();
            Dados.Columns.Add("DATA");
            Dados.Columns.Add("HORA");
            Dados.Columns.Add("USUARIO");
            Dados.Columns.Add("DESCRICAO");

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(Local, Encoding.Default).ToList();

            foreach (string line in lines)
            {
                if (line.Split(';')[0] == DATA.ToShortDateString())
                {
                    DataRow DR = Dados.NewRow();
                    DR["DATA"] = Convert.ToDateTime(line.Split(';')[0]);
                    DR["HORA"] = Convert.ToDateTime(line.Split(';')[1]);
                    DR["USUARIO"] = line.Split(';')[2];
                    DR["DESCRICAO"] = line.Split(';')[3];

                    Dados.Rows.Add();
                }
            }

            return Dados;
        }

        public DataTable DadosCompletos(string Local)
        {
            DataTable Dados = new DataTable();
            Dados.Columns.Add("DATA");
            Dados.Columns.Add("HORA");
            Dados.Columns.Add("USUARIO");
            Dados.Columns.Add("DESCRICAO");

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(Local, Encoding.Default).ToList();

            foreach (string line in lines)
            {
                DataRow DR = Dados.NewRow();
                DR["DATA"] = Convert.ToDateTime(line.Split(';')[0]);
                DR["HORA"] = Convert.ToDateTime(line.Split(';')[1]);
                DR["USUARIO"] = line.Split(';')[2];
                DR["DESCRICAO"] = line.Split(';')[3];

                Dados.Rows.Add();
            }

            return Dados;
        }
    }
}

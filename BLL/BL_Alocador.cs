using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BL_Alocador
    {
        private DA_Alocador ObjDA = new DA_Alocador();

        //Variáveis
        public long ID { get; private set; }
        public string NOME { get; private set; }

        //Métodos de Dados
        public DataTable DadosTable()
        {
            try { return ObjDA.DadosCompletos(); }
            catch { return new DataTable(); }
            //catch (ArgumentException e) { /*new BL_LogErro().Inserir("BL_ALOCADOR - DadosTable", "Erro: " + e.Message);*/  return new DataTable();}
        }

    }
}

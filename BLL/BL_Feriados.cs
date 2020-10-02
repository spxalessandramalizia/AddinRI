using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BL_Feriados
    {
        //Atributos E Construtor
        private DA_Feriados ObjDA;
        public DateTime DATA;
        public string NOME;

        public BL_Feriados() { ObjDA = new DA_Feriados(); }

        public BL_Feriados(DateTime DATA, string NOME)
        {
            ObjDA = new DA_Feriados();
            this.DATA = DATA;
            this.NOME = NOME;
        }

        //Método de Dados
        public void Inserir()
        {
            try { ObjDA.Inserir(DATA, NOME); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Feriados - Inserir", "Erro: " + e.Message); }
        }

        public List<BL_Feriados> Dados()
        {
            DataTable Table = new DataTable();

            try { Table = ObjDA.Dados(); }
            catch (Exception e) { new BL_LogErro().Inserir("BL_Feriados - Dados", "Erro: " + e.Message); return new List<BL_Feriados>(); }

            List<BL_Feriados> Lista = new List<BL_Feriados>();

            foreach (DataRow dr in Table.Rows)
            {
                DateTime Data;
                string Nome;
                BL_Feriados Feriado;
                try
                {
                    Data = Convert.ToDateTime(dr["DATA"]);
                    Nome = dr["FERIADO"].ToString();
                    Feriado = new BL_Feriados(Data, Nome);
                    Lista.Add(Feriado);
                }
                catch (Exception e) { new BL_LogErro().Inserir("BL_Feriados - Dados", "Erro: " + e.Message); }
            }

            return Lista;
        }
        //Métodos da Classe
        public DateTime CalculaCotizacao(DateTime Data, int Prazo, string Tipo)
        {
            DateTime Ans;
            if (Tipo == "U") { Ans = AddWorkDays(Data, Prazo); } //Dias úteis
            else { Ans = Data.AddDays(Prazo); } //Dias corridos
            if (Tipo == "C" && IsHoliday(Ans)) { Ans = AddWorkDays(Ans, 1); } //Cotização diária
            else if (Tipo == "M") //Cotização mensal
            {
                Ans = LastWorkDay(Ans.Year, Ans.Month);
                if (Ans < Data.AddDays(Prazo))
                {
                    int Year = Data.AddDays(Prazo).Year;
                    int Month = Data.AddDays(Prazo).Month;
                    if (Month == 12) { Year++; Month = 1; }
                    Ans = LastWorkDay(Year, Month);
                }
            }
            else if (Tipo == "T") { Ans = NextMonth(Ans); } //Cotização trimestral

            return Ans;
        }

        public DateTime CalculaLiquidacao(DateTime Data, int Prazo)
        {
            return AddWorkDays(Data, Prazo);
        }

        //Métodos auxiliares
        private static bool IsHoliday(DateTime Data)
        {
            DateTime[] Feriados = new BL_Feriados().Dados().Select(x => x.DATA).ToArray();
            return Feriados.Contains(Data) || Data.DayOfWeek == DayOfWeek.Saturday || Data.DayOfWeek == DayOfWeek.Sunday;
        }

        private bool IsLastWorkDay(DateTime Data)
        {
            int Year = Data.Month == 12 ? Data.Year : Data.Year + 1;
            int Month = Data.Month == 12 ? 1 : Data.Month;
            DateTime DiaPrimeiro = new DateTime(Year, Month + 1, 1);
            if (AddWorkDays(DiaPrimeiro, -1) == Data) { return true; }
            return false;
        }

        private DateTime LastWorkDay(int Year, int Month)
        {
            if (Month == 12) { Year++; Month = 0; }
            DateTime DiaPrimeiro = new DateTime(Year, Month + 1, 1);
            return AddWorkDays(DiaPrimeiro, -1);
        }

        private DateTime NextMonth(DateTime Data)
        {
            DateTime Ans = new DateTime();
            Double Trimestre = Data.Month / 3.0;
            if (Trimestre >= 0 && Trimestre <= 1) { Ans = LastWorkDay(Data.Year, 3); }
            else if (Trimestre > 1 && Trimestre <= 2) { Ans = LastWorkDay(Data.Year, 6); }
            else if (Trimestre > 2 && Trimestre <= 3) { Ans = LastWorkDay(Data.Year, 9); }
            else if (Trimestre > 3 && Trimestre <= 4) { Ans = LastWorkDay(Data.Year, 12); }

            return Ans;
        }

        public DateTime AddWorkDays(DateTime Data, int Dias)
        {
            int Incremnto = Dias > 0 ? 1 : -1;

            while (Dias != 0)
            {
                Data = Data.AddDays(Incremnto);
                if (!IsHoliday(Data) && Data.DayOfWeek != DayOfWeek.Saturday && Data.DayOfWeek != DayOfWeek.Sunday)
                {
                    Dias -= Incremnto;
                }
            }

            return Data;
        }
    }
}

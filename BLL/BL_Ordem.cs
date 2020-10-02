using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Security.Principal;

namespace BLL
{
    public class BL_Ordem
    {
        private DA_Ordem ObjDA = new DA_Ordem();

        //Variáveis
        #region
        public string IDORDEM { get; private set; }
        public string USUARIO { get; private set; }
        public DateTime HORARIO { get; private set; }
        public DateTime DATA { get; private set; }
        public string DE { get; private set; }
        public string ASSUNTO { get; private set; }
        public string STATUS { get; private set; }
        public List<BL_Boleta> BOLETAS { get; private set; }
        #endregion

        //Métodos de Dados
        #region
        public string Inserir(string FROM, string SUBJECT)
        {
            ObjDA.Inserir(WindowsIdentity.GetCurrent().Name.Split('\\')[1], DateTime.Now, DateTime.Today, FROM, SUBJECT, "Pendente");
            return Criptografa(ObjDA.MaxID());
        }
        public void Editar(string IDORDEM, string STATUS) { ObjDA.Editar(Descriptografa(IDORDEM), STATUS); }
        public void Deletar(string IDORDEM) { ObjDA.Deletar(Descriptografa(IDORDEM)); }
        public List<BL_Ordem> DadosPorData(DateTime Dia)
        {
            DataTable Table = new DataTable();
            List<BL_Ordem> Data = new List<BL_Ordem>();
            List<BL_Boleta> BoletasAux = new List<BL_Boleta>();
            BoletasAux = BoletasAux.Concat(new BL_Boleta().DadosDia(Dia)).ToList();
            BoletasAux = BoletasAux.Concat(new BL_Boleta().DadosZeragemDia(Dia)).ToList();

            Table = ObjDA.DadosPorDia(Dia);

            foreach (DataRow dr in Table.Rows)
            {
                BL_Ordem Aux = new BL_Ordem
                {
                    IDORDEM = Criptografa(Convert.ToInt64(dr["IDORDEM"])),
                    USUARIO = dr["USUARIO"].ToString(),
                    HORARIO = Convert.ToDateTime(dr["HORARIO"].ToString()),
                    DATA = Convert.ToDateTime(dr["DATA"]),
                    DE = dr["DE"].ToString(),
                    ASSUNTO = dr["ASSUNTO"].ToString(),
                    BOLETAS = BoletasAux.Where(x => x.IDORDEM == Criptografa(Convert.ToInt64(dr["IDORDEM"]))).ToList(),
                };

                Aux.STATUS = StatusOrdem(Aux.BOLETAS);
                Data.Add(Aux);
            }

            return Data;
        }
        public BL_Ordem DadosPorIDORDEM(string IDORDEM)
        {
            DataTable Table = new DataTable();
            Table = ObjDA.DadosPorIDORDEM(Descriptografa(IDORDEM));

            foreach (DataRow dr in Table.Rows)
            {
                BL_Ordem Aux = new BL_Ordem
                {
                    IDORDEM = Criptografa(Convert.ToInt64(dr["IDORDEM"])),
                    USUARIO = dr["USUARIO"].ToString(),
                    HORARIO = Convert.ToDateTime(dr["HORARIO"].ToString()),
                    DATA = Convert.ToDateTime(dr["DATA"]),
                    DE = dr["DE"].ToString(),
                    ASSUNTO = dr["ASSUNTO"].ToString(),
                    BOLETAS = new BL_Boleta().DadosIDORDEM(IDORDEM),
                };

                Aux.STATUS = StatusOrdem(Aux.BOLETAS);

                return Aux;
            }
            return new BL_Ordem();
        }
        #endregion

        //Funções Auxiliares
        #region
        private string StatusOrdem(List<BL_Boleta> Boletas)
        {
            //Status Possiveis Ordem -> Pendente, Em Andamento, Cancelado, Boletado, Concluído
            //Status Boleta -> Pendente, Cadastro Pendente, TCR Pendente, Cancelado, Liberado, Liquidação, Boletado, Concluído

            //Cancelado
            if (Boletas.Where(x => x.STATUS == "Cancelado").ToList().Count == Boletas.Count) { return "Cancelado"; }

            //Boletado
            else if (Boletas.Where(x => x.STATUS == "Boletado" || x.STATUS == "Cancelado").ToList().Count == Boletas.Count) { return "Boletado"; }

            //Concluído
            else if (Boletas.Where(x => x.STATUS == "Concluído" || x.STATUS == "Cancelado").ToList().Count == Boletas.ToList().Count) { return "Concluído"; }

            //Boletado com boletas concluídas
            else if (Boletas.Where(x => x.STATUS == "Boletado" || x.STATUS == "Concluído" || x.STATUS == "Cancelado").ToList().Count == Boletas.Count) { return "Boletado"; }

            //Pendente
            else if (Boletas.Where(x => x.STATUS != "Cancelado" && x.STATUS != "Boletado" && x.STATUS != "Concluído" && x.STATUS != "Liquidação" && x.STATUS != "Validando").ToList().Count == Boletas.Count) { return "Pendente"; }

            //Em andamento
            else { return "Em andamento"; }
        }
        public string DisplayOrdem { get { return HORARIO.ToShortTimeString() + " - " + DE; } }
        private string Criptografa(Int64 ID)
        {
            string R = "";
            string Base = "QPWOEIRUTYALSKDJFHGZMXNCBV";

            while (ID > 0)
            {
                R = R + Base.Substring(Convert.ToInt16(ID - Base.Length * Convert.ToInt64(ID / Base.Length)), 1);
                ID = Convert.ToInt64(ID / Base.Length);
            }

            return R;
        }
        private long Descriptografa(string IDCRIP)
        {
            string Base = "QPWOEIRUTYALSKDJFHGZMXNCBV";

            long R = 0;

            for (int i = 0; i < IDCRIP.Length; i++)
            {
                int AUXPOS = Base.IndexOf(IDCRIP.Substring(i, 1));
                long PW = 1;

                for (int j = 0; j < i; j++) { PW = PW * Base.Length; }

                long RSUM = AUXPOS * PW;
                R = R + RSUM;
            }

            return R;
        }
        #endregion
    }
}

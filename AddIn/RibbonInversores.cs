using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using BLL;
using System.Globalization;

namespace AddIn
{
    public partial class RibbonInversores
    {
        List<NovaOrdem> NovaOrdens;
        NovaOrdem Formulario;

        public void GetFormulario()
        {
            NovaOrdens = System.Windows.Forms.Application.OpenForms.OfType<NovaOrdem>().ToList();
            Formulario = NovaOrdens.FirstOrDefault();
        }
        private string DisplayContaCorrente(string Banco, string Agencia, string Conta, string Digito)
        {
            string ans = ""; long aux;
            aux = Convert.ToInt64(Banco);
            ans += aux.ToString();
            aux = Convert.ToInt64(Agencia);
            ans += " - " + aux.ToString();
            aux = Convert.ToInt64(Conta);
            ans += " - " + aux.ToString();
            aux = Convert.ToInt64(Digito);
            ans += " - " + aux.ToString();
            return ans;
        }
        
        private void BtnCSHG_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] DATA = Regex.Split(BODY, @"\r?\n|\r");

            try
            {
                for (int i = 5; DATA[i] != ""; i++)
                {
                    string[] BOL = DATA[i].Split('\t');

                    //Cria boleta com base nos dados da linha
                    long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[2], ""));
                    BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();
                    BL_FIQ FIQ = new BL_FIQ().Dados().FirstOrDefault(x => x.CNPJ == Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[5], "")));
                    string OP = BOL[3].Trim();
                    decimal VALOR = 0;

                    if (Cotista == null)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }
                    if (FIQ == null)
                    {
                        MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    string CODOP = "", Status = "";
                    int IndiceLiq = 0, IndiceConta = 0;
                    if (OP == "Aplicação")
                    {
                        VALOR = Convert.ToDecimal(BOL[6]);
                        CODOP = "AP";
                        Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, FIQ.CODFUND,
                            Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                        if (DATA.Length <= 31) {
                            IndiceLiq = 8; IndiceConta = 9;
                        }
                        else
                        {
                            IndiceLiq = 10; IndiceConta = 11;
                        }
                    }
                    else if (OP == "Resgate")
                    {
                        IndiceLiq = 10; IndiceConta = 11;
                        if (BOL[6] != "  ") //Resgate Financeiro
                        {
                            VALOR = Convert.ToDecimal(BOL[6]);
                            CODOP = "R";
                        }
                        else if (BOL[7] != "  " && BOL[8].Trim() == "Não") //Resgate por Cotas
                        {
                            VALOR = Math.Round(Convert.ToDecimal(BOL[7]), 5);
                            CODOP = "RC";
                        }
                        else if (BOL[7] != "  " && BOL[8].Trim() == "Sim") //Resgate Total
                        {
                            VALOR = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, FIQ.CODFUND).QNTCOTAS;
                            CODOP = "RT";
                        }
                    }

                    string Conta = "", Liquidacao = BOL[IndiceLiq].Trim();
                    if (Liquidacao == "CETIP")
                    {

                        Conta = BOL[IndiceConta].Trim().Split(' ')[1];
                        Conta = Conta.Insert(6, " ");

                        List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                            .Where(x => x.TIPOCONTA == "Cetip").ToList();
                        if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                        {
                            MessageBox.Show($"Conta cetip {Conta} não cadastrada!"); return;
                        }
                    }
                    else if (Liquidacao == "TRANSF" || Liquidacao == "TED")
                    {
                        if (OP == "Aplicação") { Conta = "VIA TED"; }
                        else
                        {
                            string[] DadosBanc = BOL[IndiceConta].Trim().Split('/');
                            Conta = DisplayContaCorrente(DadosBanc[0].Split(':')[1], DadosBanc[1].Split(':')[1],
                                DadosBanc[2].Split(':')[1].Split('-')[0], DadosBanc[2].Split(':')[1].Split('-')[1]);

                            List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                            if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                            {
                                MessageBox.Show($"Conta de crétdito {Conta} não cadastrada!");
                                Formulario.DataGridBoletas.Rows.Clear(); return;
                            }
                        }
                    }

                    List<BL_Boleta> Boletas = new List<BL_Boleta>();
                    if(CODOP == "R" && FIQ.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                    else if(CODOP != "AP" && FIQ.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, FIQ, VALOR, DateTime.Today, CODOP, Conta); }
                    else
                    {
                        Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, FIQ, VALOR, DateTime.Today, CODOP, Conta));
                        if(CODOP == "AP") { Boletas[0].STATUS = Status; }
                    }

                    Boletas.OrderBy(x => x.COTIZACAO).ToList();
                    foreach (BL_Boleta Boleta in Boletas)
                    {
                        Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                            Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                    }
                }
                if (DATA[5] == "") { new BL_LogErro().Inserir("Addin - Inversor CSHG", "Não foi possível realizar a inversão."); return; }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor CSHG", "Não foi possível realizar a inversão."); }
        }

        private void BtnSantander_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            string[] BOL = Regex.Split(BODY, @"\r\n\r\n");
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            List<BL_FIQ> Fundos = new BL_FIQ().Dados().Where(x => x.ALOCADOR == "SANTANDER" || x.ALOCADOR == "").ToList();
            int linha = 12;
            try
            {
                while (!BOL[linha].Contains("MIDDLE OFFICE"))
                {
                    long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[linha + 4], ""));
                    BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                    string FUNDO = BOL[linha + 2].Split(' ')[0];
                    BL_FIQ Fundo;
                    if (FUNDO.Contains("GLOBEMASTER")) { Fundo = new BL_FIQ().DadosPorCODFUND(63193); }
                    else { Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(FUNDO)); }
                    
                    if(Fundos.Where(x => x.NOME.Contains(FUNDO)).Count() > 1){
                        FUNDO += " " + BOL[linha + 2].Split(' ')[1];
                        Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(FUNDO));
                    }

                    if (Cotista == null)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }
                    if (Fundo == null || Fundos.Where(x => x.NOME.Contains(FUNDO)).Count() > 1)
                    { MessageBox.Show($"Fundo não reconhecido!\nLinha {linha / 6 - 1} desconsiderada!"); linha += 6; continue; }

                    string Operacao = BOL[linha + 1], CodOp = "", Status = "";
                    decimal Valor = 0;
                    if (Operacao == "APLICA")
                    {
                        CodOp = "AP";
                        Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                            Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                    }
                    else
                    {
                        if (Operacao == "RESGATA") { CodOp = "R"; }
                        else if (Operacao == "Resgate Total")
                        {
                            CodOp = "RT";
                            Valor = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS;
                        }
                    }

                    string VALOR = BOL[linha + 3];
                    VALOR = VALOR.Replace('R', ' '); VALOR = VALOR.Replace('$', ' ');
                    VALOR = VALOR.Replace('(', ' '); VALOR = VALOR.Replace(')', ' ');
                    VALOR = VALOR.Trim();
                    if (VALOR != "") { Valor = Convert.ToDecimal(VALOR); }

                    string[] DadosBanc = BOL[linha + 5].Split('/');
                    string Conta;
                    if (DadosBanc.Count() == 1) //Conta Cetip
                    {
                        if (DadosBanc[0].Split('.').Count() == 1) { Conta = "CETIP: " + DadosBanc[0].Split('-')[0] + DadosBanc[0].Split('-')[1]; }
                        else
                        {
                            Conta = "CETIP: " + DadosBanc[0].Split('.')[0] + DadosBanc[0].Split('.')[1]
                            + DadosBanc[0].Split('.')[2].Split('-')[0] + DadosBanc[0].Split('.')[2].Split('-')[1];
                        }


                        List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                            .Where(x => x.TIPOCONTA == "Cetip").ToList();
                        if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                        {
                            MessageBox.Show($"Conta cetip {Conta} não cadastrada!");
                            Formulario.DataGridBoletas.Rows.Clear(); return;
                        }
                    }
                    else //Transferência
                    {
                        if (Operacao == "APLICA") { Conta = "VIA TED"; }
                        else
                        {
                            Conta = DisplayContaCorrente(DadosBanc[0].Replace('\t', ' ').Trim(), DadosBanc[1],
                                DadosBanc[2].Split('-')[0], DadosBanc[2].Split('-')[1]);

                            List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                            if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                            {
                                MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                                Formulario.DataGridBoletas.Rows.Clear(); return;
                            }
                        }
                    }

                    List<BL_Boleta> Boletas = new List<BL_Boleta>();
                    if (CodOp == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                    else if (CodOp != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CodOp, Conta); }
                    else
                    {
                        Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CodOp, Conta));
                        if (CodOp == "AP") { Boletas[0].STATUS = Status; }
                    }

                    Boletas.OrderBy(x => x.COTIZACAO).ToList();
                    foreach (BL_Boleta Boleta in Boletas)
                    {
                        Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                            Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                    }
                    linha += 6;
                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor Santander", "Não foi possível realizar a inversão."); }

        }

        private void BtnItau_Click(object sender, RibbonControlEventArgs e)
        {//Ordem no corpo do email. Implementar inversor para a ordem anexada (Instruções - SPX)
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] DATA = Regex.Split(BODY, @"\r\n\r\n");
            string[] BOL = Regex.Split(DATA[1], @"\r\n");
            if (BOL[0] == "")
            {
                BOL = BOL.Skip(1).Take(BOL.Length - 1).ToArray();
            }

            try
            {
                string aux = BOL[4].Split(':')[1].Trim();
                long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(aux, ""));
                BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                if (Cotista == null)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                //Fundos exclusivos do Itaú
                List<BL_FIQ> Fundos = new BL_FIQ().Dados().Where(x => x.ALOCADOR == "ITAU").ToList();
                BL_FIQ Fundo = null;
                aux = BOL[0].Split(':')[1].Trim();
                if (aux == "ITAU PV SPX LANCER 2 FUNDO DE INVESTIMENTOS EM COTAS")
                {
                    Fundo = Fundos.FirstOrDefault(x => x.CODFUND == 63528);
                    Fundos = Fundos.Where(x => x.CODFUND != Fundo.CODFUND).ToList();
                }
                else if (Fundos.Where(x => x.NOME.Contains(aux.Split(' ')[0])).Count() == 1)
                { Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(aux.Split(' ')[0])); } //Fundos exclusivos
                if (Fundo == null || aux.Split(' ')[0] == "SPX")
                {//Fundos gerais
                    Fundos = new BL_FIQ().Dados().Where(x => x.ALOCADOR == "").ToList();
                    string Master = aux.Split(' ')[1];

                    if ((Master == "NIMITZ" || Master == "RAPTOR") && Fundos.Where(x => x.NOME.Contains(Master + " " + aux.Split(' ')[2].Substring(0, 1))).Count() == 1)
                    { Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(Master + " " + aux.Split(' ')[2].Substring(0, 1))); }
                    else if (aux == "SPX RAPTOR FEEDER FICFI MM") { Fundo = Fundos.FirstOrDefault(x => x.CODFUND == 62455); }
                    else if (Fundos.Where(x => x.NOME.Contains(Master)).Count() == 1) { Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(Master)); }
                    else
                    {
                        Fundos = new BL_FIQ().Dados();
                        if (Fundos.Where(x => x.NOME.Contains(aux.Split(' ')[0])).Count() == 1)
                        { Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(aux.Split(' ')[0])); }
                    }
                }
                
                if (Fundo == null)
                {
                    MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                string Operacao = BOL[1].Split(':')[1].Trim();
                string CODOP = "", Status = "", Conta = "";
                decimal Valor = 0;
                if (Operacao == "Aplicação")
                {
                    CODOP = "AP";
                    Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                        Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                    aux = BOL[2].Split(':')[1]; aux = aux.Replace('R', ' ');
                    aux = aux.Replace('$', ' '); aux = aux.Trim();
                    Valor = Convert.ToDecimal(aux);
                    Conta = "VIA TED";
                }
                else
                {
                    Conta = DisplayContaCorrente(BOL[5].Split(':')[1].Trim(), BOL[6].Split(':')[1].Trim(),
                        BOL[7].Split(':')[1].Split('-')[0].Trim(), BOL[7].Split(':')[1].Split('-')[1]);

                    List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                    if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                    {
                        MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    if (Operacao == "Resgate")
                    {
                        CODOP = "R";
                        aux = BOL[2].Split(':')[1]; aux = aux.Replace('R', ' ');
                        aux = aux.Replace('$', ' '); aux = aux.Trim();
                        Valor = Convert.ToDecimal(aux);
                    }
                    else if (Operacao == "Resgate Total")
                    {
                        CODOP = "RT";
                        Valor = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS;
                    }
                }

                List<BL_Boleta> Boletas = new List<BL_Boleta>();
                if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                else if (CODOP != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                else
                {
                    Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                    if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                }

                Boletas.OrderBy(x => x.COTIZACAO).ToList();
                foreach (BL_Boleta Boleta in Boletas)
                {
                    Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                        Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor Itaú", "Não foi possível realizar a inversão."); }


        }

        private void BtnBradesco_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(BODY, @"\r\n\r\n");

            try
            {
                long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[14].Trim(), ""));
                BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                if (Cotista == null)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[18].Trim(), ""));
                BL_FIQ Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CNPJ == CpfCnpj);

                if (Fundo == null)
                {
                    MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                decimal Valor; string aux = BOL[22];
                aux = aux.Replace('R', ' '); aux = aux.Replace('$', ' ');
                aux = aux.Trim();
                Valor = Convert.ToDecimal(aux);

                string Operacao = BOL[20].Trim();
                string CODOP = "", Status = "";
                if (Operacao == "Aplicação")
                {
                    CODOP = "AP";
                    Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                        Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                }
                else
                {
                    if (Fundo.CODMASTER == 61984)
                    {
                        MessageBox.Show("Resgates do Raptor devem ser feitos Manualmente!\nNão foi possivel realizar a inversão!"); return;
                    }
                    if (Operacao == "Resgate") { CODOP = "R"; }
                    else if (Operacao == "Resgate Total")
                    {
                        CODOP = "RT";
                        Valor = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS;
                    }
                }

                string DadosBancarios = BOL[24].Trim(), Conta = "";
                try
                {
                    if (DadosBancarios.Contains("CETIP"))
                    {
                        DadosBancarios = DadosBancarios.Split(':')[1].Trim();
                        Conta = "CETIP: " + DadosBancarios.Split('-')[0] + DadosBancarios.Split('-')[1];

                        List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(x => x.TIPOCONTA == "Cetip").ToList();
                        if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                        {
                            MessageBox.Show($"Conta cetip {Conta} não cadastrada!");
                            Formulario.DataGridBoletas.Rows.Clear(); return;
                        }
                    }
                    else
                    {
                        if (Operacao == "Aplicação") { Conta = "VIA TED"; }
                        else
                        {
                            Conta = DisplayContaCorrente("237", DadosBancarios.Split(' ')[2].Split('-')[0],
                                DadosBancarios.Split(' ')[4].Split('-')[0], DadosBancarios.Split(' ')[4].Split('-')[1]);

                            List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                    .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                            if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                            {
                                MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                                Formulario.DataGridBoletas.Rows.Clear(); return;
                            }
                        }
                    }
                }
                catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor Bradesco", "Erro na inversão da forma de liquidação."); }

                List<BL_Boleta> Boletas = new List<BL_Boleta>();
                if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                else if (CODOP != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                else
                {
                    Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                    if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                }

                Boletas.OrderBy(x => x.COTIZACAO).ToList();
                foreach (BL_Boleta Boleta in Boletas)
                {
                    Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                        Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor Bradesco", "Não foi possível realizar a inversão."); }

        }

        private void BtnBB_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(Regex.Split(BODY, @"\r\n\r\n")[2], @"\r\n");

            try
            {
                List<BL_Cotista> Cotistas = new BL_Cotista().DadosCompleto().Where(x => x.NOME.Contains("BB ")).ToList();
                List<BL_FIQ> Fundos = new BL_FIQ().Dados().Where(x => x.ALOCADOR == "BB").ToList();
                //Fundos exclusivos do BB

                BL_FIQ Fundo;
                string aux = BOL[2].Split(':')[1].Trim();
                Fundo = Fundos.FirstOrDefault(x => x.NOME.Contains(aux.Split(' ')[0]));

                if (Fundo == null || Fundos.Where(x => x.NOME.Contains(aux.Split(' ')[0])).Count() > 1)
                {
                    MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                for (int linha = 6; linha < BOL.Length && BOL[linha].Trim() != ""; linha += 2)
                {
                    BL_Cotista Cotista = null;
                    aux = BOL[linha].Split(':')[1].Trim();
                    if (aux.Contains("ESPELHO") && Cotistas.Where(x => x.NOME.Contains("ESP") && x.NOME.Contains(aux.Split(' ')[5])).Count() == 1)
                    {
                        Cotista = Cotistas.FirstOrDefault(x => x.NOME.Contains("ESP") && x.NOME.Contains(aux.Split(' ')[5]));
                    }
                    else if (aux.Contains("BB MODULO") && Cotistas.Where(x => x.NOME.Contains(aux.Split(' ')[2])).Count() == 1)
                    {
                        Cotista = Cotistas.FirstOrDefault(x => x.NOME.Contains(aux.Split(' ')[2]));
                    }
                    else if (aux.Contains("BB PREVIDENCIA") && Cotistas.Where(x => x.NOME.Contains("BB PREV")).Count() == 1)
                    {
                        Cotista = Cotistas.FirstOrDefault(x => x.NOME.Contains("BB PREV"));
                    }
                    else if ((aux.Contains("MULTIGESTOR MODULO") || aux.Contains("MULTIGESTOR MÓDULO"))
                                && Cotistas.Where(x => x.NOME.Contains("MOD" + aux.Split(' ')[4])).Count() == 1)
                    {
                        Cotista = Cotistas.FirstOrDefault(x => x.NOME.Contains("MOD" + aux.Split(' ')[4]));
                    }
                    else if (Cotistas.Where(x => x.NOME.Contains(aux.Split(' ')[3])).Count() == 1)
                    {
                        Cotista = Cotistas.FirstOrDefault(x => x.NOME.Contains(aux.Split(' ')[3]));
                    }

                    if (Cotista == null)
                    {
                        MessageBox.Show($"O nome {aux} não retornou cotistas!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    aux = BOL[linha + 1].Replace('_', ' ').Trim();
                    string Operacao = aux.Split(' ')[0];
                    string Status = "", CODOP = "";
                    if (Operacao == "Aplicac")
                    {
                        CODOP = "AP";
                        Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                            Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                    }
                    else if (Operacao == "Resgate") { CODOP = "R"; }

                    decimal Valor = Convert.ToDecimal(aux.Split(' ').Last());

                    aux = aux.Split(' ')[3];
                    string Conta = "CETIP: ";
                    Conta += aux.Split('.')[0];
                    aux = aux.Split('.')[1];
                    Conta += aux.Split('-')[0] + aux.Split('-')[1];

                    List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(x => x.TIPOCONTA == "Cetip").ToList();
                    if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                    {
                        MessageBox.Show($"Conta cetip {Conta} não cadastrada!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    List<BL_Boleta> Boletas = new List<BL_Boleta>();
                    if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                    else if (Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                    else
                    {
                        Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                        if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                    }

                    Boletas.OrderBy(x => x.COTIZACAO).ToList();
                    foreach (BL_Boleta Boleta in Boletas)
                    {
                        Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                            Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                    }
                }
            }
            catch (Exception err) { new BL_LogErro().Inserir("Addin - Inversor BB", "Não foi possível realizar a inversão."); }

        }

        private void BtnBTG_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(BODY, @"\r\n\r\n");

            try
            {
                List<BL_Cotista> Cotistas = new BL_Cotista().DadosCompleto();
                int linha = 12;
                while (BOL[linha].Split('\t').Length == 1)
                {
                    long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[linha + 5], ""));
                    BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                    if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    if (Cotista == null)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(BOL[linha + 3], ""));
                    BL_FIQ Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CNPJ == CpfCnpj);

                    if (Fundo == null)
                    {
                        MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    string Operacao = BOL[linha + 1];
                    string CODOP = "", Status = "", Conta;
                    decimal Valor = 0;
                    if (Operacao == "Aplicação")
                    {
                        CODOP = "AP"; Conta = "VIA TED";
                        Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                            Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                    }
                    else
                    {
                        string aux = BOL[linha + 6];
                        Conta = DisplayContaCorrente(BOL[linha + 7].Split('-')[1].Trim(), BOL[linha + 8],
                            aux.Substring(0, aux.Length - 1), aux.Substring(aux.Length - 1));

                        List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                    .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                        if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                        {
                            MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                            Formulario.DataGridBoletas.Rows.Clear(); return;
                        }

                        if (Operacao == "Resgate") { CODOP = "R"; }
                        else if (Operacao == "Resgate Total")
                        {
                            CODOP = "RT";
                            Valor = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS;
                        }
                    }

                    if (Operacao != "Resgate Total") { Valor = Convert.ToDecimal(BOL[linha + 4], new CultureInfo("en-US")); }

                    List<BL_Boleta> Boletas = new List<BL_Boleta>();
                    if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                    else if (CODOP != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                    else
                    {
                        Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                        if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                    }

                    Boletas.OrderBy(x => x.COTIZACAO).ToList();
                    foreach (BL_Boleta Boleta in Boletas)
                    {
                        Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                            Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                    }
                    linha += 9;

                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor BTG", "Não foi possível realizar a inversão."); }
        }

        private void BtnVitreo_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(BODY, @"\r?\n|\r");

            try
            {
                string aux = BOL[1].Trim().Split(' ').Last();
                long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(aux, ""));
                BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                if (Cotista == null)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                string nome = BOL[2].Split(':')[1].Trim();
                aux = nome.Split(' ')[0] + " " + nome.Split(' ')[1];
                BL_FIQ Fundo = null;
                if (nome == "SPX LANCER ICATU MULTIPREVI FICFIM") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 63308); }
                else if (new BL_FIQ().Dados().Where(x => x.NOME.Contains(aux)).Count() == 1) { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.NOME.Contains(aux)); }

                if (Fundo == null)
                {
                    MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                string CODOP = "", Status = "";
                if (BOL[0].Contains("aplicação"))
                {
                    CODOP = "AP";
                    Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                        Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                }
                else
                {
                    MessageBox.Show("Operação não identificada.\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                string Conta;
                decimal Valor;
                if (BOL[3].Contains("VIA TED"))
                {
                    Conta = "VIA TED";
                    aux = BOL[3].Trim().Split(' ')[1];
                    Valor = Convert.ToDecimal(aux);
                }
                else
                {
                    aux = BOL[3].Trim().Split(' ').Last();
                    Valor = Convert.ToDecimal(aux);

                    aux = BOL[4].Trim().Split(' ').Last();
                    if (aux == "CETIP") { aux = BOL[5].Split(':')[1].Trim(); }
                    Conta = "CETIP: " + aux;

                    List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(x => x.TIPOCONTA == "Cetip").ToList();
                    if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                    {
                        MessageBox.Show($"Conta cetip {Conta} não cadastrada!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                }

                Formulario.DataGridBoletas.Rows.Add(Cotista.CODCOT, Fundo.CODFUND, Cotista.CPFCNPJ, Cotista.NOME, Fundo.NOME, CODOP, Status, Valor, Conta);
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor Vitreo", "Não foi possível realizar a inversão."); }
        }

        private void BtnXP_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(BODY, @"\r\n\r\n");

            try
            {
                string aux = BOL[3].Split('-')[2].Trim();
                aux += BOL[3].Split('-')[3].Trim();
                long CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(aux, ""));
                BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                if (Cotista == null)
                {
                    MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                aux = BOL[4].Split('-')[2].Trim();
                aux += BOL[4].Split('-')[3].Trim();
                CpfCnpj = Convert.ToInt64(new Regex(@"[^\d]").Replace(aux, ""));
                BL_FIQ Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CNPJ == CpfCnpj);

                if (Fundo == null)
                {
                    MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                    Formulario.DataGridBoletas.Rows.Clear(); return;
                }

                if (!BOL[2].Contains("via TED"))
                { MessageBox.Show("Forma de liquidação não identificada. \nNão foi possível realizar a inversão!"); return; }

                string Operação = BOL[5].Split(':')[1].Trim();
                string CODOP = "", Status = "", Conta = "";
                if (Operação == "Aplicação")
                {
                    CODOP = "AP"; Conta = "VIA TED";
                    Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                        Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                }
                else
                {
                    if (Operação == "Resgate") { CODOP = "R"; }
                    else { MessageBox.Show("Operação não identificada.\nNão foi possível realizar a inversão!"); return; }

                    Conta = DisplayContaCorrente(BOL[8].Split(':')[1].Trim(), BOL[9].Split(':')[1].Trim(),
                        BOL[10].Split(':')[1].Trim().Split('-')[0], BOL[10].Split(':')[1].Trim().Split('-')[1]);

                    List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                    if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                    {
                        MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                }

                aux = BOL[6].Split(':')[1];
                aux = aux.Replace('R', ' '); aux = aux.Replace('$', ' ');
                aux = aux.Trim();
                decimal Valor = Convert.ToDecimal(aux, new CultureInfo("en-US"));

                List<BL_Boleta> Boletas = new List<BL_Boleta>();
                if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                else if (CODOP != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                else
                {
                    Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                    if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                }

                Boletas.OrderBy(x => x.COTIZACAO).ToList();
                foreach (BL_Boleta Boleta in Boletas)
                {
                    Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                        Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor XP", "Não foi possível realizar a inversão."); }
        }

        private void BtnJGP_Click(object sender, RibbonControlEventArgs e)
        {
            GetFormulario();
            string BODY;
            if (Formulario != null) { BODY = Formulario.EmailRecebido.Body; }
            else { MessageBox.Show("Não há formulário Nova Ordem aberto."); return; }
            Formulario.DataGridBoletas.Rows.Clear(); Formulario.Limpar();

            string[] BOL = Regex.Split(BODY, @"\r\n\r\n");
            int i = 0;

            try
            {
                while (!BOL[15+i].Contains("Att")) { 
                    long CpfCnpj = Convert.ToInt64(BOL[23+i]);
                    BL_Cotista Cotista = new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).FirstOrDefault();

                    if (new BL_Cotista().DadosPorCPFCNPJ(CpfCnpj).Count() > 1)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou um cotista único!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    if (Cotista == null)
                    {
                        MessageBox.Show($"CPF / CNPJ {CpfCnpj} não retornou cotistas!\nNão foi possível realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    BL_FIQ Fundo = null;
                    if (BOL[21 + i] == "ILLUSTRIOUS FIC FIM") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 62092); }
                    else if (BOL[21 + i] == "SPX LANCER ICATU MULTIPREVI FIC FIM") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 63308); }
                    else if (BOL[21 + i] == "RAPTOR L FIC FIM IE CP") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 62455); }
                    else if (BOL[21 + i] == "SPX NIMITZ FEEDER FIC FIM") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 62128); }
                    else if (BOL[21 + i] == "SPX FALCON FIC FIA") { Fundo = new BL_FIQ().Dados().FirstOrDefault(x => x.CODFUND == 62011); }

                    if (Fundo == null)
                    {
                        MessageBox.Show("Fundo não reconhecido!\nNão foi possivel realizar a inversão!");
                        Formulario.DataGridBoletas.Rows.Clear(); return;
                    }

                    string Operacao = BOL[19 + i];
                    string CODOP = "", Status = "";
                    decimal Valor = 0;
                    if (Operacao == "Compra")
                    {
                        CODOP = "AP";
                        Status = new BL_Boleta().VerificarCotista(Cotista.CODCOT, Fundo.CODFUND,
                            Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha);
                    }
                    else
                    {
                        if (Operacao == "Venda") { CODOP = "R"; }
                        else if (Operacao == "Resgate Total")
                        {
                            CODOP = "RT";
                            Valor = new BL_Saldo().DadosPorCODCOTeCODFUND(Cotista.CODCOT, Fundo.CODFUND).QNTCOTAS;
                        }
                    }

                    if (Operacao != "Resgate Total") { Valor = Convert.ToDecimal(BOL[20 + i]); }

                    string Conta = "";
                    if (BOL[22 + i] == "CETIP")
                    {
                        Conta = "CETIP: " + BOL[24 + i];
                        List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                    .Where(x => x.TIPOCONTA == "Cetip").ToList();
                        if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta cetip não cadastrada
                        {
                            MessageBox.Show($"Conta cetip {Conta} não cadastrada!");
                            Formulario.DataGridBoletas.Rows.Clear(); return;
                        }

                    }
                    else if (BOL[22 + i] == "TED")
                    {
                        if (Operacao == "Compra") { Conta = "VIA TED"; }
                        else
                        {
                            Conta = DisplayContaCorrente(BOL[24 + i].Split('-')[0].Trim(), BOL[25 + i], BOL[26 + i].Split('-')[0], BOL[26 + i].Split('-')[1]);

                            List<BL_ContaCredito> ContasCadastro = new BL_ContaCredito().DadosPorCODCOT(Cotista.CODCOT)
                                            .Where(Cont => Cont.TIPOCONTA == "CC").ToList();
                            if (!ContasCadastro.Select(x => x.DISPLAYCONTA).ToArray().Contains(Conta)) //Conta de crédito não cadastrada
                            {
                                MessageBox.Show($"Conta de crédito {Conta} não cadastrada!");
                                Formulario.DataGridBoletas.Rows.Clear(); return;
                            }
                        }
                    }

                    List<BL_Boleta> Boletas = new List<BL_Boleta>();
                    if (CODOP == "R" && Fundo.LOCKUP != 0) { MessageBox.Show("Não é possível resgatar por financeiro em fundos com lockup!"); }
                    else if (CODOP != "AP" && Fundo.LOCKUP != 0) { Boletas = new BL_Boleta().BoletaPorCautela(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta); }
                    else
                    {
                        Boletas.Add(new BL_Boleta().GeraBoleta(Cotista, Fundo, Valor, DateTime.Today, CODOP, Conta));
                        if (CODOP == "AP") { Boletas[0].STATUS = Status; }
                    }

                    Boletas.OrderBy(x => x.COTIZACAO).ToList();

                    foreach (BL_Boleta Boleta in Boletas)
                    {
                        Formulario.DataGridBoletas.Rows.Add(Boleta.CODCOT, Boleta.CODFUND, Boleta.CPFCNPJ, Boleta.NOME, Boleta.FUNDO, Boleta.OPERACAO, Boleta.STATUS,
                            Boleta.VALOR, Boleta.CONTA, Boleta.COTIZACAO.ToShortDateString(), Boleta.IMPACTO.ToShortDateString(), Boleta.CAUTELA);
                    }
                    i+=12;
                }
            }
            catch (Exception) { new BL_LogErro().Inserir("Addin - Inversor JGP", "Não foi possível realizar a inversão."); }

        }
    }
}

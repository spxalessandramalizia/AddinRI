using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AddIn
{
    public partial class Confirmacoes : Form
    {
        //Movimentar o Formulário
        #region MoveForm
        Point lastpoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) { lastpoint = new Point(e.X, e.Y); }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastpoint.X; this.Top += e.Y - lastpoint.Y; } }
        #endregion

        //Dados
        #region       
        List<BL_Boleta> Boletas = new List<BL_Boleta>();
        List<BL_Ordem> Ordens = new List<BL_Ordem>();
        List<BL_BoletaIntrag> BoletaIntrag = new List<BL_BoletaIntrag>();
        Dictionary<long, BL_Cotista> Cotistas = new Dictionary<long, BL_Cotista>();
        Dictionary<long, string> FIQs = new Dictionary<long, string>();
        #endregion

        public Confirmacoes() { InitializeComponent(); }

        //Carrega Dados
        private void Confirmacoes_Load(object sender, EventArgs e)
        {
            Boletas = new BL_Boleta().DadosDia(DateTime.Today);
            Ordens = new BL_Ordem().DadosPorData(DateTime.Today);
            Cotistas = new BL_Cotista().DadosCompleto().ToDictionary(key => key.CODCOT, value => value);
            FIQs = new BL_FIQ().Dados().ToDictionary(key => key.CODFUND, value => value.NOME);

            CmbBoxOrdem.DisplayMember = "DisplayOrdem";
            CmbBoxOrdem.ValueMember = "Idordem";
            CmbBoxOrdem.DataSource = Ordens.Where(x => x.STATUS == "Boletado" || x.STATUS == "Cancelado").ToList();
        }

        //Fecha o Formulario
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        //Preecher DataGridBoletas com a ordem selecionada
        private void CmbBoxOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridBoletas.Rows.Clear();

            if (CmbBoxOrdem.SelectedIndex > -1)
            {
                List<BL_Boleta> BoletaAux = Boletas.Where(x => x.IDORDEM == CmbBoxOrdem.SelectedValue.ToString()).ToList();

                foreach (BL_Boleta B in BoletaAux)
                {
                    DataGridBoletas.Rows.Add(new string[] { Cotistas[B.CODCOT].CPFCNPJ.ToString(), Cotistas[B.CODCOT].NOME, FIQs[B.CODFUND], B.OPERACAO, B.STATUS, B.VALOR.ToString(), B.CONTA });
                }
            }
        }

        //Gera Email de Confirmação
        private void BtnGerarEmail_Click(object sender, EventArgs e)
        {
            if (CmbBoxOrdem.SelectedIndex > -1)
            {
                List<BL_Boleta> BoletasAux = Boletas.Where(x => x.IDORDEM == CmbBoxOrdem.SelectedValue.ToString() && (x.STATUS == "Boletado" || x.STATUS == "Concluído")).ToList();

                //Header
                string HTML = "";

                if (CheckTabela.Checked)
                {
                    HTML = new HTML().ConfirmaTabela(BoletasAux);
                }
                else
                {
                    HTML = new HTML().ConfirmaIndividual(BoletasAux);
                }
     
                try
                {
                    foreach (MailItem email in new Microsoft.Office.Interop.Outlook.Application().ActiveExplorer().Selection)
                    {
                        MailItem Mail = email.ReplyAll();
                        Mail.Recipients.Add("ri@spxcapital.com.br");
                        Mail.HTMLBody =  HTML + Mail.HTMLBody;
                        Mail.Display();
                        break;
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao gerar o email.");
                }
            }
        }

        private void BtnConcluidas_Click(object sender, EventArgs e)
        {
            CmbBoxOrdem.DataSource = Ordens.Where(x => x.STATUS == "Boletado" || x.STATUS == "Cancelado" || x.STATUS == "Concluído").ToList();
        }
    }
}

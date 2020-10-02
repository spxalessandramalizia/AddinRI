using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using BLL;

namespace AddIn
{
    public partial class RibbonRI
    {
        //Abre Formulario de nova ordem
        private void BtnNovaOrdem_Click(object sender, RibbonControlEventArgs e)
        {
            //Emails Selecionados
            List<MailItem> Emails = new Microsoft.Office.Interop.Outlook.Application().ActiveExplorer().Selection.OfType<MailItem>().ToList();

            //Valida se possui apenas um email selecionado
            if (Emails.Count != 1) { MessageBox.Show("Prezado, favor selecionar 1 Email!"); return; }

            if (System.Windows.Forms.Application.OpenForms.OfType<NovaOrdem>().Count() == 1)
            {
                System.Windows.Forms.Application.OpenForms.OfType<NovaOrdem>().First().Close();
            }
      
            new NovaOrdem(Emails[0], new List<BL_Boleta>()).Show();
        }

        //Abre Formulario de Confirmação
        private void BtnConfirma_Click(object sender, RibbonControlEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.OfType<Confirmacoes>().Count() == 1)
            {
                System.Windows.Forms.Application.OpenForms.OfType<Confirmacoes>().First().Close();
            }

            new Confirmacoes().Show();
        }

        //Gerar Emails Relacionados a Ordens Boletadas
        private void BtnGerarEmails_Click(object sender, RibbonControlEventArgs e)
        {
            List<BL_Ordem> Ordens = new BL_Ordem().DadosPorData(DateTime.Today).Where(x => x.STATUS == "Boletado").ToList();
            List<BL_Boleta> Boletas = new BL_Boleta().DadosDia(DateTime.Today);

            //Seleciona a pasta Boletas Recebidas
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace nameSpace = outlook.GetNamespace("MAPI");
            MAPIFolder mapiFolderPurchase = nameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox).Parent;
            MAPIFolder BoletadosFolder = mapiFolderPurchase.Folders["Boletas Recebidas"];

            foreach (MailItem Email in BoletadosFolder.Items.OfType<MailItem>())
            {
                if (Ordens.Where(x => Email.Body.Contains("ID ORDEM (" + x.IDORDEM + ")")).Count() == 1)
                {
                    BL_Ordem OrdemEmail = Ordens.FirstOrDefault(x => Email.Body.Contains("ID ORDEM (" + x.IDORDEM + ")"));

                    string HTML = "";

                    if (Boletas.Where(x => x.IDORDEM == OrdemEmail.IDORDEM).Count() > 2)
                    {
                        HTML = new HTML().ConfirmaTabela(Boletas.Where(x => x.IDORDEM == OrdemEmail.IDORDEM).ToList());
                    }
                    else
                    {
                        HTML = new HTML().ConfirmaIndividual(Boletas.Where(x => x.IDORDEM == OrdemEmail.IDORDEM).ToList());
                    }

                    MailItem EmailReply = Email.ReplyAll();
                    EmailReply.HTMLBody = HTML + EmailReply.HTMLBody;
                    EmailReply.Display();

                    //if (MessageBox.Show("Deseja enviar o Email gerado?", "Envio de Email", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //{
                    //    //EmailReply.Send();
                    //    //OrdemEmail.Editar(OrdemEmail.IDORDEM, "Concluído"); 
                    //}
                    //else { EmailReply.Close(OlInspectorClose.olDiscard); }
                }
            }
        }

        //Atuali Usuario e Senha
        private void BtnAtualizar_Click(object sender, RibbonControlEventArgs e)
        {
            //Verifica com Usuário
            if(DialogResult.Yes != MessageBox.Show("Usuário: "+TextUser.Text+"\nSenha: "+TextSenha.Text,"Alteração Senha", MessageBoxButtons.YesNo)) { return; }

            Properties.Settings.Default.Usuario = TextUser.Text; TextUser.Text = "";
            Properties.Settings.Default.Senha = TextSenha.Text; TextSenha.Text = "";

            MessageBox.Show("Dados Atualizados!");
        }

        //Inversores
        #region
        private void BtnItau_Click(object sender, RibbonControlEventArgs e)
        {
            //Fundos
            Dictionary<string, long> INVFUND = new Dictionary<string, long>
            {
                {"ITAU PV SPX LANCER 2 FUNDO DE INVESTIMENTOS EM COTAS", 63528 },
                {"PROWLER FIC DE FIA", 62010 },
                {"GROWLER FIC DE FI MM", 62161 },
            };

            //InvOperação
            Dictionary<string, string> INVOP = new Dictionary<string, string>
            {
                {"Aplicação", "AP" },
                {"Resgate", "R" },
                {"Resgate Total", "RT" },
            };

            //Emails Selecionados
            List<MailItem> Emails = new Microsoft.Office.Interop.Outlook.Application().ActiveExplorer().Selection.OfType<MailItem>().ToList();

            //Valida se possui apenas um email selecionado
            if (Emails.Count != 1) { MessageBox.Show("Prezado, favor selecionar 1 Email!"); return; }

            List<string> Body = Emails[0].Body.Split('\n').ToList();

            //BL_Boleta Bol = new BL_Boleta();
          
            foreach (string line in Body)
            {
                //if (line.Contains("Movimentação no Fundo: ")) { Bol.CODFUND = INVFUND[line.Replace("Movimentação no Fundo: ", "").Trim()]; }

                //if (line.Contains("Operação: ")) { Bol.OPERACAO = INVOP[line.Replace("Operação: ", "").Trim()]; }

                if (line.Contains("Valor: ")) { }

                if (line.Contains("CNPJ: ")) { }

                MessageBox.Show(line);
            }
        }
        #endregion

        //private void BtnGetEmails_Click(object sender, RibbonControlEventArgs e)
        //{
        //    Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
        //    NameSpace nameSpace = outlook.GetNamespace("MAPI");

        //    Microsoft.Office.Interop.Outlook.Items Itens = nameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox).Items;

        //    Itens = Itens.Restrict("[ReceivedTime]>'" + DateTime.Today.ToString("MM/dd/yyyy 00:00") + "'");

        //    foreach (MailItem Email in Itens.OfType<MailItem>().ToList()) { MessageBox.Show(Email.SenderName); }

        //    //MAPIFolder mapiFolderPurchase = nameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
        //    //MAPIFolder BoletadosFolder = mapiFolderPurchase.Folders["Boletas do Dia"];
        //}
    }

}

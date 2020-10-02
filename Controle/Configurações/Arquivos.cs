using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class Arquivos : Form
    {
        string FILE = "";
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public Arquivos()
        {
            InitializeComponent();

            TextLogErro.Text = Properties.Settings.Default.LogErros;

            ComboBoxFile.Items.Add("CADCOTI");
            ComboBoxFile.Items.Add("ARQSDFD0");

            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            new BL_Saldo().AtualizarDados("spx.op35", "258369");
            //Properties.Settings.Default.LogErros = TextLogErro.Text; 
            //Properties.Settings.Default.Save();

            //MessageBox.Show("Locais Salvos!");
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnBuscarArquivo_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
            if (OpenFile.FileNames.Count() == 1) { TextBoxLocal.Text = OpenFile.FileName; }

            try
            {
                int len = File.ReadAllLines(TextBoxLocal.Text.Replace(@"\", @"\\"))[5].Length;

                if (len != 1264 && len != 600)
                {
                    TextBoxLocal.Text = ""; MessageBox.Show("Arquivo Inválido!", "ERRO");
                }
            }
            catch
            {
                TextBoxLocal.Text = "";
                MessageBox.Show("Arquivo Inválido!", "ERRO");
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e) { FILE = ComboBoxFile.Text; BackData.RunWorkerAsync(); }

        private void BackData_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] lines = File.ReadAllLines(TextBoxLocal.Text.Replace(@"\", @"\\"), Encoding.Default);

            if (FILE == "CADCOTI")
            {
                int step = lines.Length / 100;
                int contline = 0;

                foreach (string linha in lines)
                {
                    if (linha.Length == 1264)
                    {
                        string CODEXT = linha.Substring(6, 4) + linha.Substring(12, 8);
                        string Nome = linha.Substring(20, 30).Trim();
                        string CNPJ = linha.Substring(60, 14).Trim();
                        string Data = linha.Substring(1241, 2) + "/" + linha.Substring(1239, 2) + "/" + linha.Substring(1235, 4);

                        if (linha.Substring(58, 1) == "F")
                        {
                            CNPJ = linha.Substring(63, 11).Trim();
                        }

                        //DCTA.ADD(Convert.ToDouble(CODEXT), Nome, CNPJ, Data);
                    }
                    contline++;
                    if (contline % step == 0)
                    {
                        int steps = contline / step;
                        BackData.ReportProgress(steps);
                    }
                }
            }
            else if (FILE == "ARQSDFD0")
            {
                BL_Saldo ObjSaldo = new BL_Saldo();
                ObjSaldo.Deletar();

                int step = lines.Length / 100;
                int contline = 0;

                foreach (string linha in lines)
                {
                    if (linha.Length == 600)
                    {
                        long CODCOT = Convert.ToInt64(linha.Substring(17, 14));
                        long CODFUND = Convert.ToInt64(linha.Substring(6, 5));
                        string TIPOREGISTRO = linha.Substring(48, 2) == "20"? "Simples":"Total" ;
                        long CAUTELA = Convert.ToInt64(linha.Substring(50, 10));
                        decimal QNTCOTAS = Convert.ToDecimal(linha.Substring(111, 15))/100000;
                        DateTime DATACOTA = DateTime.ParseExact(linha.Substring(139,8), "yyyyMMdd", null);       
                        decimal COTA = Convert.ToDecimal(linha.Substring(147, 15))/10000000;

                        ObjSaldo.Inserir(CODCOT, CODFUND, TIPOREGISTRO, CAUTELA, QNTCOTAS, DATACOTA, COTA);
                    }
                    contline++;
                    if (contline % step == 0)
                    {
                        int steps = contline / step;
                        BackData.ReportProgress(steps);
                    }
                }
            }
        }

        private void BackData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UploadBar.PerformStep();
        }

        private void BackData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // MessageBox.Show("Upload concluído com sucesso!");
        }

        private void BtnAtualizaSaldos_Click(object sender, EventArgs e)
        {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null || Usuario.USUARIO == "" || Usuario.SENHA == "") { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            new BL_Saldo().AtualizarDados(Usuario.USUARIO, Usuario.SENHA);
            MessageBox.Show("Completo");
        }

        private void BtnAtualizaCotas_Click(object sender, EventArgs e)
        {
            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario == null || Usuario.USUARIO == "" || Usuario.SENHA == "") { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); return; }
            new BL_Cota().AtualizarDados(Usuario.USUARIO, Usuario.SENHA);
            MessageBox.Show("Completo");
        }
    }
}

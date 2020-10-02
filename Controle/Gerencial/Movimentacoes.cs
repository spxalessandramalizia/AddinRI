using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class Movimentacoes : Form
    {
        public Movimentacoes()
        {
            InitializeComponent();

            //Atualizar Datas
            #region
            CmBoxData.Items.Clear();
            CmBoxData.DataSource = new BL_Boleta().DatasSolicitacao();
            #endregion
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (CmBoxData.SelectedIndex > -1) { AtualizarDados(); }
            else { MessageBox.Show("Favor selecionar uma data!"); }
        }

        //Atualizar Dados Movimentações ou Ordens
        private void AtualizarDados()
        {     
            if (CmbBoxTipo.Text == "Ordens")
            {
                List<BL_Ordem> Ordens = new List<BL_Ordem>();

                if (CheckID.Checked) { Ordens = new List<BL_Ordem> { new BL_Ordem().DadosPorIDORDEM(TextBoxID.Text) }; }
                else { Ordens = new BL_Ordem().DadosPorData(Convert.ToDateTime(CmBoxData.Text)); }

                PanelOrdens.Controls.Clear();

                //Dicionario Auxiliar
                Dictionary<string, Int64> StatusCheck = new Dictionary<string, Int64>();

                foreach (BL_Ordem Ordem in Ordens)
                {
                    if (!StatusCheck.ContainsKey(Ordem.STATUS)) { StatusCheck.Add(Ordem.STATUS, 1); }
                    else { StatusCheck[Ordem.STATUS]++; }

                    PanelOrdens.Controls.Add(new OrdemControl(PanelOrdens) { SetOrdem = Ordem, SetOld = true, });
                }

                DataGridOrdens.Visible = false;
                PanelOrdens.Visible = true;

                //Limpa DataGridStatus
                DataGridStatus.Rows.Clear();

                //Adiciona Linhas ao StatusGrid
                foreach (var Item in StatusCheck) { DataGridStatus.Rows.Add(new string[] { "true", Item.Key, Item.Value.ToString() }); }
            }
            else
            {
                DataGridOrdens.Rows.Clear();

                List<BL_Boleta> Boletas = new List<BL_Boleta>();

                if (CheckID.Checked) { Boletas = new BL_Boleta().DadosIDORDEM(TextBoxID.Text); }
                else { Boletas = new BL_Boleta().DadosDia(Convert.ToDateTime(CmBoxData.Text)); }

                foreach (BL_Boleta B in Boletas)
                {
                    string status = B.STATUS;
                    if (B.STATUS.Length >= 12)
                        status = B.STATUS.Substring(0, 12);
                    DataGridOrdens.Rows.Add(new string[] { B.IDBOLETA.ToString(), B.IDORDEM.ToString(), B.CODCOT.ToString(), B.CPFCNPJ.ToString(), B.NOME, B.FUNDO, B.OPERACAO, B.VALOR.ToString(), B.CONTA, status });
                }

                PanelOrdens.Visible = false;
                DataGridOrdens.Visible = true;
                DataGridOrdens.ClearSelection();

                //Limpa DataGridStatus
                DataGridStatus.Rows.Clear();

                //Dicionario Auxiliar
                Dictionary<string, Int64> StatusCheck = new Dictionary<string, Int64>();

                //ColumnIndex
                int ColumnAux = new int();
                foreach (DataGridViewColumn Col in DataGridOrdens.Columns) { if (Col.Name == "STATUS_") { ColumnAux = Col.Index; } }

                //Adicionar Status ao DataGridStatus
                foreach (DataGridViewRow DR in DataGridOrdens.Rows)
                {
                    string Status = DR.Cells[ColumnAux].Value.ToString();
                    if (!StatusCheck.ContainsKey(Status))
                    { StatusCheck.Add(Status, 1); }
                    else { StatusCheck[Status]++; }
                }

                //Adiciona Linhas ao StatusGrid
                foreach (var Item in StatusCheck) { DataGridStatus.Rows.Add(new string[] { "true", Item.Key, Item.Value.ToString() }); }
            }
        }

        //Cell Formating Ordens
        private void DataGridOrdens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridOrdens.Columns[e.ColumnIndex].Name == "STATUS_")
            {
                //Liberado
                //Pendente
                //Validando
                //Boletado
                //Concluído
                //Cancelado
                //Liquidação

                if (e.Value.ToString() == "Liberado")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 255, 153);
                }
                else if (e.Value.ToString() == "Pendente")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if (e.Value.ToString() == "Validando")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(209, 233, 200);
                }
                else if (e.Value.ToString() == "Boletado")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(153, 255, 153);
                }
                else if (e.Value.ToString() == "Concluído")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(179, 230, 179);
                }
                else if (e.Value.ToString() == "Cancelado")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if (e.Value.ToString() == "Liquidação")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 163, 102);
                }
            }
        }

        private void CheckID_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckID.Checked) { TextBoxID.Enabled = true; }
            else { TextBoxID.Text = ""; TextBoxID.Enabled = false; }
        }

    }
}

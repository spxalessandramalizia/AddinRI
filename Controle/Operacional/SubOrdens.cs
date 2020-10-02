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

namespace Controle
{
    public partial class SubOrdens : Form
    {
        //Inicializador
        public SubOrdens()
        {
            InitializeComponent();
            CmbBoxVisualiza.SelectedIndex = 1;
            AtualizarDados();
        }

        //Fechar
        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        //Atualizar Dados Movimentações ou Ordens
        private void AtualizarDados()
        {
            if (CmbBoxVisualiza.Text == "Ordens")
            {
                List<BL_Ordem> Ordens = new BL_Ordem().DadosPorData(DateTime.Today);

                PanelOrdens.Controls.Clear();

                //Dicionario Auxiliar
                Dictionary<string, Int64> StatusCheck = new Dictionary<string, Int64>();

                foreach (BL_Ordem Ordem in Ordens)
                {
                    if (!StatusCheck.ContainsKey(Ordem.STATUS)) { StatusCheck.Add(Ordem.STATUS, 1); }
                    else { StatusCheck[Ordem.STATUS]++; }

                    PanelOrdens.Controls.Add(new OrdemControl(PanelOrdens) { SetOrdem = Ordem });
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
                Boletas = Boletas.Concat(new BL_Boleta().DadosDia(DateTime.Today)).ToList();
                Boletas = Boletas.Concat(new BL_Boleta().DadosZeragemDia(DateTime.Today)).ToList();

                foreach (BL_Boleta BL in Boletas)
                {
                    string status = BL.STATUS;
                    //if (BL.STATUS.Length>=12)
                    //    status = BL.STATUS.Substring(0, 12);
                    DataGridOrdens.Rows.Add(new string[] {BL.IDBOLETA.ToString(),BL.IDORDEM.ToString(),BL.CODCOT.ToString(), BL.CPFCNPJ.ToString(),BL.NOME,BL.FUNDO,BL.OPERACAO,BL.VALOR.ToString(),BL.CONTA,status });
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

        //Atualizar Dados com Base no Modo de visualização Selecionado
        private void BtnAtualizar_Click(object sender, EventArgs e) { AtualizarDados(); }
 
        //Atualiza Movimentações com base nos Status selecionados
        private void AtualizarStatus()
        {
            List<string> StatusNot = new List<string>();
            int ColumnAux = new int();
            
            //Adiciona Status Não Selecionados
            foreach (DataGridViewRow DR in DataGridStatus.Rows) { if (DR.Cells[0].Value.ToString() == "False") { StatusNot.Add(DR.Cells[1].Value.ToString()); } }

            if (CmbBoxVisualiza.Text == "Ordens")
            {
                //Adicionar Status ao DataGridStatus
                foreach (OrdemControl Control in PanelOrdens.Controls.OfType<OrdemControl>())
                {
                    if (StatusNot.Contains(Control.Ordem.STATUS)) { Control.Visible = false; }
                    else { Control.Visible = true; }
                }
            }
            else
            {
                //Encontra Index da Coluna "Status"
                foreach (DataGridViewColumn Col in DataGridOrdens.Columns) { if (Col.Name == "STATUS_") { ColumnAux = Col.Index; } }

                foreach (DataGridViewRow DR in DataGridOrdens.Rows)
                {
                    if (StatusNot.Contains(DR.Cells[ColumnAux].Value.ToString())) { DR.Visible = false; }
                    else { DR.Visible = true; }
                }

                DataGridOrdens.ClearSelection();
            }
        }

        //Atualiza Movimentações com base nos Status selecionados
        private void DataGridStatus_CellEndEdit(object sender, DataGridViewCellEventArgs e) { AtualizarStatus(); }

        //Remove Selecção do data Grid
        private void DataGridStatus_SelectionChanged(object sender, EventArgs e) { DataGridStatus.ClearSelection(); }

        //Atualiza Movimentações com base nos Status selecionados
        private void DataGridOrdens_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { AtualizarStatus(); }

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
                //Cadastro pendente

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
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(250, 117, 117);
                }
            }
        }

        //Atualizar Dados
        private void CmbBoxVisualiza_SelectedValueChanged(object sender, EventArgs e) { AtualizarDados(); }

        private void SubOrdens_VisibleChanged(object sender, EventArgs e)
        {
            AtualizarDados();
        }

    }
}

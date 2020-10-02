using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle
{
    public partial class ControleResgates : Form
    {
        public ControleResgates()
        {
            InitializeComponent();
        }

        private void ControleResgates_Load(object sender, EventArgs e)
        {
            //Carrega dados antigos no CmbBox
            CmbOld.DataSource = new BL_RegistroResgate().DatasSolicitacao();

            DataGridResgates.DataSource = new BL_RegistroResgate().DadosDisplay(DateTime.Today);
            //DataGridResgates.Columns["ID"].Visible = false;
            //DataGridResgates.Columns["CODFUND"].Visible = false;
            //DataGridResgates.Columns["CODEXT"].Visible = false;
            DataGridResgates.ClearSelection();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridResgates.DataSource = new BL_RegistroResgate().DadosDisplay(DateTime.Today);
            DataGridResgates.ClearSelection();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Valida se tem registro selecionado
            if (DataGridResgates.SelectedRows.Count != 1) { MessageBox.Show("Favor Selecionar um Registro"); return; }

            //Se o registros estiver pendente
            if (DataGridResgates.SelectedRows[0].Cells[8].Value.ToString() == "Pendente")
            {
                new BL_RegistroResgate().DeletarIDREGISTRO(Convert.ToInt64(DataGridResgates.SelectedRows[0].Cells[0].Value));
                DataGridResgates.DataSource = new BL_RegistroResgate().DadosDisplay(DateTime.Today);
                DataGridResgates.ClearSelection();
            }
            else { MessageBox.Show("Não é possivel excluir um resgate não pendente."); }
        }

        private void DataGridResgates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridResgates.Columns[e.ColumnIndex].Name == "STATUS")
            {
                if (e.Value.ToString() == "Cancelado")
                { e.CellStyle.ForeColor = Color.Black; e.CellStyle.BackColor = Color.FromArgb(255, 153, 153); }

                else if (e.Value.ToString() == "Pendente")
                { e.CellStyle.ForeColor = Color.Black; e.CellStyle.BackColor = Color.FromArgb(255, 153, 153); }

                else if (e.Value.ToString() == "Concluído")
                { e.CellStyle.ForeColor = Color.Black; e.CellStyle.BackColor = Color.FromArgb(179, 230, 179); }

                else if (e.Value.ToString() == "Liberado")
                { e.CellStyle.ForeColor = Color.Black; e.CellStyle.BackColor = Color.FromArgb(255, 255, 153); }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        private void DataGridResgates_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridResgates.ClearSelection();
        }

        private void BtnCarregarOld_Click(object sender, EventArgs e)
        {
            try { Convert.ToDateTime(CmbOld.Text); }
            catch { MessageBox.Show("Erro ao converter data!"); return; }
        
            DataGridResgates.DataSource = new BL_RegistroResgate().DadosDisplay(Convert.ToDateTime(CmbOld.Text));
            DataGridResgates.ClearSelection();
        }
    
    }
}

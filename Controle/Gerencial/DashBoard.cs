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
    public partial class DashBoard : Form
    {
        public DashBoard() { InitializeComponent(); } 

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridFIQs.DataSource = new BL_FIQ().DadosPorSolicitacao(DateTime.Today);
            DataGridFIQs.ClearSelection();
            DataGridFIQs.Columns[0].Width = 150;
            DataGridFIQs.Columns[1].Width = 150;
            DataGridFIQs.Columns[1].DefaultCellStyle.Format = "N2";
            DataGridFIQs.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridBatimento.DataSource = new BL_FIQ().BatimentoSolicitacao(DateTime.Today);
            DataGridBatimento.ClearSelection();
            DataGridBatimento.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridBatimento.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridBatimento.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridResgates.DataSource = BatimentoResgates();
            DataGridResgates.ClearSelection();
            DataGridResgates.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridResgates.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void DataGridBatimento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (double.TryParse(e.Value.ToString(), out double d)) { e.Value = d.ToString("N2"); }

            if (this.DataGridBatimento.Columns[e.ColumnIndex].Name == "CHECK")
            {
                if (Convert.ToDecimal(e.Value) != 0)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else 
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(179, 230, 179);
                }
            }
        }

        private void BtnAplicaMaster_Click(object sender, EventArgs e)
        {
            if (BtnAplica.Text == "Por Master")
            {
                DataGridFIQs.DataSource = new BL_Master().DadosPorSolicitacao(DateTime.Today);
                DataGridFIQs.ClearSelection();
                DataGridFIQs.Columns[0].Width = 150;
                DataGridFIQs.Columns[1].Width = 150;
                DataGridFIQs.Columns[1].DefaultCellStyle.Format = "N2";
                DataGridFIQs.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                BtnAplica.Text = "Por FIQ";
            }
            else
            { 
                DataGridFIQs.DataSource = new BL_FIQ().DadosPorSolicitacao(DateTime.Today);
                DataGridFIQs.ClearSelection();
                DataGridFIQs.Columns[0].Width = 150;
                DataGridFIQs.Columns[1].Width = 150;
                DataGridFIQs.Columns[1].DefaultCellStyle.Format = "N2";
                DataGridFIQs.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                BtnAplica.Text = "Por Master";
            }
        }

        private DataTable BatimentoResgates()
        {
            DataTable Table = new DataTable();

            Table.Columns.Add("FIQ");
            Table.Columns.Add("INTRAG");
            Table.Columns.Add("CONTROLE");

            Dictionary<long, string> InvFIQ = new BL_FIQ().Dados().ToDictionary(Key => Key.CODFUND, Value => Value.NOME);
            List<BL_Boleta> Boletas = new BL_Boleta().DadosDia(DateTime.Today).Where(x => x.OPERACAO != "AP" && x.STATUS != "Cancelado").ToList();
            List<BL_BoletaIntrag> BoletasIntrag = new BL_BoletaIntrag().DadosDia(DateTime.Today).Where(x => x.OPERACAO != "AP").ToList();

            List<long> FIQs = Boletas.Select(x => x.CODFUND).ToList();
            FIQs.AddRange(BoletasIntrag.Select(x => x.CODFUND));
            FIQs = FIQs.Distinct().ToList();

            foreach (long FIQ in FIQs.Where(x => InvFIQ.Keys.Contains(x)))
            {
                DataRow DR = Table.NewRow();

                DR["FIQ"] = InvFIQ[FIQ];
                DR["INTRAG"] = BoletasIntrag.Where(x => x.CODFUND == FIQ).Count();
                DR["CONTROLE"] = Boletas.Where(x => x.CODFUND == FIQ).Count();

                Table.Rows.Add(DR);
            }

            AddTotals(ref Table);

            return Table;
        }

        private void AddTotals(ref DataTable dTable)
        {
            int[] totals = new int[dTable.Columns.Count];
            DataRow totalsRow = dTable.NewRow();
            totalsRow[0] = "TOTAL";
            for (int i = 1; i < dTable.Columns.Count; i++) 
            {
                foreach (DataRow dr in dTable.Rows)
                {
                    totals[i] += int.Parse(dr[i].ToString());
                }
                totalsRow[i] = totals[i];
            }
            dTable.Rows.Add(totalsRow);
        }

        private void DataGridResgates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridResgates.Columns[e.ColumnIndex].Name == "CONTROLE")
            {
                if (Convert.ToDecimal(e.Value) != Convert.ToDecimal(DataGridResgates.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value))
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(179, 230, 179);
                }
            }
            if(e.RowIndex == this.DataGridResgates.Rows.Count - 1)
            {
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.BackColor = Color.FromArgb(171, 173, 180);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Security.Principal;

namespace Controle
{
    public partial class OrdemControl : UserControl
    {
        private string WINDOWSNAME;
        BL_Usuario Usuario;

        public OrdemControl(FlowLayoutPanel PanelControl)
        {
            InitializeComponent();
            PainelControle = PanelControl;
            WINDOWSNAME = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }

        //Variáveis
        #region
        FlowLayoutPanel PainelControle;
        int Altura = 55;
        public BL_Ordem Ordem = new BL_Ordem();
        public bool Old = false;
        #endregion

        //Editor de Bases Externa
        #region 
        public BL_Ordem SetOrdem { get { return Ordem; } set { Ordem = value; RefreshData(); } }

        public bool SetOld { get { return Old; } set { Old = value; if (Old) { BtnOp.Visible = false; }  } }

        public void RefreshData()
        {
            Altura = 55;
        
            //Limpa DataGrid
            DataGridBoletas.Rows.Clear();

            if (Ordem.BOLETAS == null || Ordem.BOLETAS.Count == 0) { Ordem.Deletar(Ordem.IDORDEM); PainelControle.Controls.Remove(this); }

            foreach (BL_Boleta B in Ordem.BOLETAS)
            {
                string status = B.STATUS;
                //if (B.STATUS.Length >= 12)
                //    status = B.STATUS.Substring(0, 12);
                DataGridBoletas.Rows.Add(new string[] { B.IDBOLETA.ToString(), B.CODCOT.ToString(), B.CPFCNPJ.ToString(), B.NOME, B.FUNDO.ToString(), B.OPERACAO, B.VALOR.ToString(), B.CONTA, status });
                Altura += 21;
            }

            //Limita a Altura Maxima do controle
            if (Altura > 200) { Altura = 200; }

            DataGridBoletas.ClearSelection();

            LabelID.Text = "ID: " + Ordem.IDORDEM;

            LabelDe.Text = Ordem.ASSUNTO;
            LabelHora.Text = Ordem.HORARIO.ToString("hh:mm");
            LabelStatus.Text = Ordem.STATUS;

            if (Ordem.ASSUNTO.Length > 45) { LabelDe.Text = LabelDe.Text.Substring(0, 45); };

            AtualizarStatusControle();
        }
        #endregion

        //Expande e Diminui o Controle
        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            //Diminui o controle
            if (this.Height == Altura) { this.Height = 33; btnExpandir.Text = "+"; }
            //Expande o controle
            else { this.Height = Altura; btnExpandir.Text = "-"; DataGridBoletas.ClearSelection(); }
        }

        //Abre menu de edição da Boleta
        private void DataGridBoletas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {
                DataGridBoletas.Rows[e.RowIndex].Selected = true;
                string Status = DataGridBoletas.Rows[e.RowIndex].Cells[8].Value.ToString();
                string OP = DataGridBoletas.Rows[e.RowIndex].Cells[5].Value.ToString();

                MenuBoletaBoletar.Visible = MenuBoletaCancelar.Visible = MenuBoletaExcluir.Visible = true;
                MenuBoletaVerificar.Visible = false;

                if (Status == "Concluído" || Status == "Cancelado" || Status == "Boletado" || Status == "Liquidação" || SetOld)
                { MenuBoletaBoletar.Visible = MenuBoletaCancelar.Visible = MenuBoletaExcluir.Visible = false; }

                if (Status == "Pendente" || Status == "TCR Pendente" || Status == "Cadastro Pendente" || SetOld) { MenuBoletaBoletar.Visible = false; }

                if ((Status == "TCR Pendente" || Status == "Cadastro Pendente" ) && !SetOld) { MenuBoletaVerificar.Visible = true; }

                //Mostra Opções do Menu que a boleta pode operar
                BoletaMenu.Show(Cursor.Position);
            }
        }

        //Atualiza Status do controle
        private void AtualizarStatusControle()
        {
            if (Ordem.STATUS == "Pendente") { PanelHeader.BackColor = Color.FromArgb(255, 153, 153); if(!Old) BtnOp.Visible = true; BtnOp.Text = "X"; }
            else if (Ordem.STATUS == "Boletado") { PanelHeader.BackColor = Color.FromArgb(153, 255, 153); if (!Old) BtnOp.Visible = true; BtnOp.Text = "C"; }
            else if (Ordem.STATUS == "Concluído") { PanelHeader.BackColor = Color.FromArgb(179, 230, 179); BtnOp.Visible = false; }
            else if (Ordem.STATUS == "Cancelado") { PanelHeader.BackColor = Color.FromArgb(255, 153, 153); BtnOp.Visible = false; }
            else if (Ordem.STATUS == "Em andamento") { PanelHeader.BackColor = Color.FromArgb(255, 163, 102); BtnOp.Visible = false; }
        }

        //Métodos para Boletas
        #region
        private void MenuBoletaExcluir_Click(object sender, EventArgs e)
        {
            BL_Boleta BoletaAux = new BL_Boleta().BoletaPorIDBOLETA(Convert.ToInt64(DataGridBoletas.SelectedRows[0].Cells[0].Value));

            if (BoletaAux.STATUS == "Liberado" || BoletaAux.STATUS == "Pendente")
            {
                BoletaAux.Deletar(BoletaAux.IDBOLETA);
                new BL_RegistroResgate().DeletarIDBOLETA(BoletaAux.IDBOLETA);
            }
            else { MessageBox.Show("Boleta não estava Liberada ou Pendete"); }

            //Atualiza Boletas e o controle
            Ordem = Ordem.DadosPorIDORDEM(Ordem.IDORDEM);
            RefreshData();
        }
        private void MenuBoletaCancelar_Click(object sender, EventArgs e)
        {
            BL_Boleta BoletaAux = new BL_Boleta().BoletaPorIDBOLETA(Convert.ToInt64(DataGridBoletas.SelectedRows[0].Cells[0].Value));
        
            if (BoletaAux.STATUS == "Liberado" || BoletaAux.STATUS == "Pendente" || BoletaAux.STATUS == "Cadastro Pendente" || BoletaAux.STATUS == "TCR Pendente")
            {
                BoletaAux.Editar(BoletaAux.IDBOLETA,BoletaAux.COTIZACAO, BoletaAux.IMPACTO, "Cancelado");
                new BL_RegistroResgate().EditarIDBOLETA(BoletaAux.IDBOLETA, "Cancelado");
            }

            //Atualiza Boletas e o controle
            Ordem = Ordem.DadosPorIDORDEM(Ordem.IDORDEM);
            RefreshData();
        }
        private void MenuBoletaXML_Click(object sender, EventArgs e)
        {
            BL_Boleta BoletaAux = new BL_Boleta().BoletaPorIDBOLETA(Convert.ToInt64(DataGridBoletas.SelectedRows[0].Cells[0].Value));
            MessageBox.Show(BoletaAux.XML(/*BoletaAux,*/ "*****","*****"));
        }
        private void MenuBoletaVerificar_Click(object sender, EventArgs e)
        {
            BL_Boleta Aux = new BL_Boleta().BoletaPorIDBOLETA(Convert.ToInt64(DataGridBoletas.SelectedRows[0].Cells[0].Value));

            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario != null && Usuario.USUARIO != "" && Usuario.SENHA != "")
            {
                if (Aux.VerificarCotista(Aux.CODCOT, Aux.CODFUND, Properties.Settings.Default.Usuario, Properties.Settings.Default.Senha) == "Liberado")
                {
                    Aux.Editar(Aux.IDBOLETA, Aux.COTIZACAO, Aux.IMPACTO, "Liberado");
                }
                else { MessageBox.Show("Cadastro não liberado!"); }
            }
            else { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); }

            //Atualiza Boletas e o controle
            Ordem = Ordem.DadosPorIDORDEM(Ordem.IDORDEM);
            RefreshData();
        }
        private void MenuBoletaBoletar_Click(object sender, EventArgs e)
        {
            BL_Boleta Aux = new BL_Boleta().BoletaPorIDBOLETA(Convert.ToInt64(DataGridBoletas.SelectedRows[0].Cells[0].Value));

            Usuario = new BL_Usuario().DadosNome(WINDOWSNAME);
            if (Usuario != null && Usuario.USUARIO != "" && Usuario.SENHA != "")
            {
                Aux.Boletar(Aux, Usuario.USUARIO, Usuario.SENHA);
            }
            else { MessageBox.Show("Favor verificar usuário e senha nas Configurações."); }

            //Atualiza Boletas e o controle
            Ordem = Ordem.DadosPorIDORDEM(Ordem.IDORDEM);
            RefreshData();
        }
        #endregion

        //Concluir ou Excluir
        private void BtnOp_Click(object sender, EventArgs e)
        {
            if (BtnOp.Text == "C")
            {             
                Ordem.Editar(Ordem.IDORDEM, "Concluído");

                foreach (BL_Boleta Bol in new BL_Boleta().DadosIDORDEM(Ordem.IDORDEM).Where(x => x.STATUS == "Boletado"))
                {
                    Bol.Editar(Bol.IDBOLETA, Bol.COTIZACAO, Bol.IMPACTO, "Concluído");
                }

                Ordem = new BL_Ordem().DadosPorIDORDEM(Ordem.IDORDEM);
                RefreshData();
            }
            else if (BtnOp.Text == "X")
            {
                List<BL_Boleta> BoletasControle = new BL_Boleta().DadosIDORDEM(Ordem.IDORDEM);

                if (BoletasControle.Count == BoletasControle.Where(x => x.STATUS != "Boletado" && x.STATUS != "Concluído").Count())
                {
                    foreach (BL_Boleta Bol in BoletasControle)
                    {
                        Bol.Deletar(Bol.IDBOLETA);
                        new BL_RegistroResgate().DeletarIDBOLETA(Bol.IDBOLETA);
                    }

                    Ordem.Deletar(Ordem.IDORDEM);
                    PainelControle.Controls.Remove(this);
                }
                else
                {
                    MessageBox.Show("Exitem boletas já processadas. Controle Atualizado.");
                }
            }
        }

        //Formata DataGridBoletas
        private void DataGridBoletas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridBoletas.Columns[e.ColumnIndex].Name == "STATUS")
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
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.FromArgb(250, 117, 117);
                }
            }
        }
    }
}

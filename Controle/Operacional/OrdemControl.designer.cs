namespace Controle
{
    partial class OrdemControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.DataGridBoletas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINCOTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelDe = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnOp = new System.Windows.Forms.Button();
            this.BoletaMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuBoletaCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoletaExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoletaXML = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoletaVerificar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoletaBoletar = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.BoletaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(717, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "      Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ass:";
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnExpandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExpandir.Location = new System.Drawing.Point(3, 5);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(25, 25);
            this.btnExpandir.TabIndex = 51;
            this.btnExpandir.Text = "+";
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // DataGridBoletas
            // 
            this.DataGridBoletas.AllowUserToAddRows = false;
            this.DataGridBoletas.AllowUserToDeleteRows = false;
            this.DataGridBoletas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridBoletas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridBoletas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBoletas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODEXT,
            this.CPFCNPJ,
            this.NOME,
            this.FUNDO,
            this.OP,
            this.FINCOTAS,
            this.CONTA,
            this.STATUS});
            this.DataGridBoletas.EnableHeadersVisualStyles = false;
            this.DataGridBoletas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.DataGridBoletas.Location = new System.Drawing.Point(3, 34);
            this.DataGridBoletas.MultiSelect = false;
            this.DataGridBoletas.Name = "DataGridBoletas";
            this.DataGridBoletas.ReadOnly = true;
            this.DataGridBoletas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBoletas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBoletas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridBoletas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridBoletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBoletas.Size = new System.Drawing.Size(955, 160);
            this.DataGridBoletas.TabIndex = 50;
            this.DataGridBoletas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridBoletas_CellFormatting);
            this.DataGridBoletas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridBoletas_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 44;
            // 
            // CODEXT
            // 
            this.CODEXT.HeaderText = "CODEXT";
            this.CODEXT.Name = "CODEXT";
            this.CODEXT.ReadOnly = true;
            this.CODEXT.Width = 110;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPFCNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Width = 110;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 175;
            // 
            // FUNDO
            // 
            this.FUNDO.HeaderText = "FUNDO";
            this.FUNDO.Name = "FUNDO";
            this.FUNDO.ReadOnly = true;
            this.FUNDO.Width = 145;
            // 
            // OP
            // 
            this.OP.HeaderText = "OP";
            this.OP.Name = "OP";
            this.OP.ReadOnly = true;
            this.OP.Width = 30;
            // 
            // FINCOTAS
            // 
            this.FINCOTAS.HeaderText = "FIN / COTAS";
            this.FINCOTAS.Name = "FINCOTAS";
            this.FINCOTAS.ReadOnly = true;
            this.FINCOTAS.Width = 140;
            // 
            // CONTA
            // 
            this.CONTA.HeaderText = "CONTA";
            this.CONTA.Name = "CONTA";
            this.CONTA.ReadOnly = true;
            this.CONTA.Width = 150;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 94;
            // 
            // LabelDe
            // 
            this.LabelDe.AutoSize = true;
            this.LabelDe.BackColor = System.Drawing.Color.Transparent;
            this.LabelDe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDe.ForeColor = System.Drawing.Color.Black;
            this.LabelDe.Location = new System.Drawing.Point(211, 8);
            this.LabelDe.Name = "LabelDe";
            this.LabelDe.Size = new System.Drawing.Size(14, 20);
            this.LabelDe.TabIndex = 56;
            this.LabelDe.Text = "-";
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.BackColor = System.Drawing.Color.Transparent;
            this.LabelHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHora.ForeColor = System.Drawing.Color.Black;
            this.LabelHora.Location = new System.Drawing.Point(646, 8);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(14, 20);
            this.LabelHora.TabIndex = 57;
            this.LabelHora.Text = "-";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.Color.Black;
            this.LabelStatus.Location = new System.Drawing.Point(778, 8);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(14, 20);
            this.LabelStatus.TabIndex = 58;
            this.LabelStatus.Text = "-";
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.BtnOp);
            this.PanelHeader.Location = new System.Drawing.Point(925, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(33, 33);
            this.PanelHeader.TabIndex = 59;
            // 
            // BtnOp
            // 
            this.BtnOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.BtnOp.FlatAppearance.BorderSize = 0;
            this.BtnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOp.Location = new System.Drawing.Point(2, 3);
            this.BtnOp.Name = "BtnOp";
            this.BtnOp.Size = new System.Drawing.Size(29, 27);
            this.BtnOp.TabIndex = 60;
            this.BtnOp.Text = "X";
            this.BtnOp.UseVisualStyleBackColor = false;
            this.BtnOp.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // BoletaMenu
            // 
            this.BoletaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBoletaCancelar,
            this.MenuBoletaExcluir,
            this.MenuBoletaXML,
            this.MenuBoletaVerificar,
            this.MenuBoletaBoletar});
            this.BoletaMenu.Name = "BoletaMenu";
            this.BoletaMenu.Size = new System.Drawing.Size(151, 114);
            // 
            // MenuBoletaCancelar
            // 
            this.MenuBoletaCancelar.Name = "MenuBoletaCancelar";
            this.MenuBoletaCancelar.Size = new System.Drawing.Size(150, 22);
            this.MenuBoletaCancelar.Text = "Cancelar";
            this.MenuBoletaCancelar.Click += new System.EventHandler(this.MenuBoletaCancelar_Click);
            // 
            // MenuBoletaExcluir
            // 
            this.MenuBoletaExcluir.Name = "MenuBoletaExcluir";
            this.MenuBoletaExcluir.Size = new System.Drawing.Size(150, 22);
            this.MenuBoletaExcluir.Text = "Excluir";
            this.MenuBoletaExcluir.Click += new System.EventHandler(this.MenuBoletaExcluir_Click);
            // 
            // MenuBoletaXML
            // 
            this.MenuBoletaXML.Name = "MenuBoletaXML";
            this.MenuBoletaXML.Size = new System.Drawing.Size(150, 22);
            this.MenuBoletaXML.Text = "Visualizar XML";
            this.MenuBoletaXML.Click += new System.EventHandler(this.MenuBoletaXML_Click);
            // 
            // MenuBoletaVerificar
            // 
            this.MenuBoletaVerificar.Name = "MenuBoletaVerificar";
            this.MenuBoletaVerificar.Size = new System.Drawing.Size(150, 22);
            this.MenuBoletaVerificar.Text = "Verificar";
            this.MenuBoletaVerificar.Click += new System.EventHandler(this.MenuBoletaVerificar_Click);
            // 
            // MenuBoletaBoletar
            // 
            this.MenuBoletaBoletar.Name = "MenuBoletaBoletar";
            this.MenuBoletaBoletar.Size = new System.Drawing.Size(150, 22);
            this.MenuBoletaBoletar.Text = "Boletar";
            this.MenuBoletaBoletar.Click += new System.EventHandler(this.MenuBoletaBoletar_Click);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.BackColor = System.Drawing.Color.Transparent;
            this.LabelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.Color.Black;
            this.LabelID.Location = new System.Drawing.Point(34, 8);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(38, 20);
            this.LabelID.TabIndex = 60;
            this.LabelID.Text = "ID: -";
            // 
            // OrdemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.LabelHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.LabelDe);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridBoletas);
            this.Controls.Add(this.btnExpandir);
            this.Name = "OrdemControl";
            this.Size = new System.Drawing.Size(961, 33);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBoletas)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.BoletaMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExpandir;
        public System.Windows.Forms.DataGridView DataGridBoletas;
        private System.Windows.Forms.Label LabelDe;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.ContextMenuStrip BoletaMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuBoletaExcluir;
        private System.Windows.Forms.ToolStripMenuItem MenuBoletaCancelar;
        private System.Windows.Forms.Button BtnOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINCOTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.ToolStripMenuItem MenuBoletaXML;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.ToolStripMenuItem MenuBoletaVerificar;
        private System.Windows.Forms.ToolStripMenuItem MenuBoletaBoletar;
    }
}

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
    public partial class LogErro : Form
    {
        public LogErro()
        {
            InitializeComponent();
        }

        private void BtnCarrega_Click(object sender, EventArgs e)
        {
            //DataGridErro.DataSource = new CONTROLE.LogErro().DadosTable();
        }

        private void BtnFechar_Click(object sender, EventArgs e) { this.Close(); }
    }
}

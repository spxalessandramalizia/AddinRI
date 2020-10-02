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
    public partial class Cotas : Form
    {
        public Cotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BL_Cota().ImportaCSV(richTextBox1.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
        }
    }
}

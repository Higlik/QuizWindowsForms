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
    public partial class frmP2 : Form
    {
        public frmP2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                this.Dispose();
                VariaveisGlobais.Acertos++;
                frmFinal pFinal = new frmFinal();
                pFinal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Resposta incorreta");
                this.Dispose();
                VariaveisGlobais.Erros++;
                frmFinal pFinal = new frmFinal();
                pFinal.ShowDialog();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnCerta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

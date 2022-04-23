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
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Resposta incorreta");
                this.Dispose();
                VariaveisGlobais.Erros++;
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
                
            }
                
         

        }
    }
}

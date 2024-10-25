using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc2
{
    public partial class TelaCarregamento : Form
    {
        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void timercarregamento_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += progressBar1.Step;


            }
            if (progressBar1.Value == 100)
            {
                TelaLogin telalogin = new TelaLogin();

                telalogin.Show();
                this.Hide();
                timercarregamento.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {
            timercarregamento.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using ProjetoTcc2.Views;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        public void exibirTela(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
                

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        public void exibirTelaInicial(object mainpanel)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);


            }
            
           TopLevel = false;
            Dock = DockStyle.Fill;
            

        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            exibirTela(new Consulta2());
            lateral.Height = btnconsulta.Height;
            lateral.Top = btnconsulta.Top;
            lateral.BringToFront();
        }

        private void btnadicionarfamilia_Click(object sender, EventArgs e)
        {
            exibirTela(new AdicionarFamilia());
            lateral.Height = btnadicionarfamilia.Height;
            lateral.Top = btnadicionarfamilia.Top;
            lateral.BringToFront();
        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            exibirTela(new Estoque2());
            lateral.Height = btnestoque.Height;
            lateral.Top = btnestoque.Top;
            lateral.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnhome_Click(object sender, EventArgs e)
        {
            exibirTela(new Telahome());
            lateral.Height= btnhome.Height;
            lateral.Top= btnhome.Top;
            lateral.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelnavigator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirTela(new Telahome());
            lateral.Height = btnestoque.Height;
            lateral.Top = btnestoque.Top;
            lateral.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exibirTela(new Calendario());  
            lateral.Height = btnestoque.Height;
            lateral.Top = btnestoque.Top;
            lateral.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exibirTela(new Estatistica());  
            lateral.Height = btnestoque.Height;
            lateral.Top = btnestoque.Top;
            lateral.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

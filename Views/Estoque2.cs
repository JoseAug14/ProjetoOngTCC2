using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc2.Views
{
    public partial class Estoque2 : Form
    {
        public void exibirTela(Form form)
        {
            // Remove todos os controles existentes no painel
            while (this.panelEstoque.Controls.Count > 0)
            {
                var oldForm = this.panelEstoque.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose(); // Libera os recursos do formulário anterior
                }
                this.panelEstoque.Controls.RemoveAt(0); // Remove o controle
            }

            // Configura o novo formulário para ser exibido no painel
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelEstoque.Controls.Add(form);
            this.panelEstoque.Tag = form; // Armazena o formulário no Tag
            form.Show(); // Exibe o formulário
        }
        public Estoque2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exibirTela(new Estoque());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirTela(new novo());
        }
    }
}

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
    public partial class Consulta2 : Form
    {
        public void exibirTela(Form form)
        {
            // Remove todos os controles existentes no painel
            while (this.panelConsulta.Controls.Count > 0)
            {
                var oldForm = this.panelConsulta.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Dispose(); // Libera os recursos do formulário anterior
                }
                this.panelConsulta.Controls.RemoveAt(0); // Remove o controle
            }

            // Configura o novo formulário para ser exibido no painel
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelConsulta.Controls.Add(form);
            this.panelConsulta.Tag = form; // Armazena o formulário no Tag
            form.Show(); // Exibe o formulário
        }
        public Consulta2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirTela(new Consulta());
        }
    }
}

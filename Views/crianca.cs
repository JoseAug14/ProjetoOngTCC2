using ProjetoTcc2.DAO;
using ProjetoTcc2.Model;
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
    public partial class crianca : Form
    {
        public crianca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crianca obj = new Crianca();

            obj.nomecrianca = txtnomecrianca.Text;
            obj.datanasccrianca = DateTime.Parse(txtdatanasccrianca.Text);
            obj.tamanho = txttamanho.Text; 
            obj.serie = txtserie.Text;
            obj.frequencia = int.Parse(txtfrequencia.Text);
            obj.media = int.Parse(txtmedia.Text);
            obj.nomeescola = txtnomeescola.Text;
            obj.telefoneescola = txttelefoneescola.Text;

            EscolaDAO escolaDAO = new EscolaDAO();
            escolaDAO.CadastrarEscola(obj);

            CriancaDAO dao = new CriancaDAO();
            dao.cadastrarCrianca(obj);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using ProjetoTcc2.DAO;
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
    public partial class Consulta : Form
    {
        
            public Consulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Alterar cor de fundo
            dataGridConsulta.BackgroundColor = Color.LightGray;

            // Cor das linhas alternadas
            dataGridConsulta.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Cor da linha selecionada
            dataGridConsulta.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            dataGridConsulta.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Cor do cabeçalho da coluna
            dataGridConsulta.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridConsulta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridConsulta.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            ResponsavelDAO dao = new ResponsavelDAO();

            dataGridConsulta.DataSource = dao.listarResponsavel();


            // Adicionando colunas ao DataTable
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nome Responsável", typeof(string));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("RG", typeof(string));
            table.Columns.Add("Telefone", typeof(string));  // Alterado para string
            table.Columns.Add("Estado Civil", typeof(string));  // Alterado para string

            // Exemplo de preenchimento do DataTable
         

            // Definindo o DataSource do DataGridView
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Quantidade", typeof(string));
            table.Columns.Add("Data", typeof(int));
            table.Columns.Add("Vencimento", typeof(int));

            table.Rows.Add(1,"","Last A",80);

           dataGridEstoque.DataSource = table;

           
            dataGridEstoque.Columns[0].Width = 250;
            dataGridEstoque.Columns[1].Width = 250;
            dataGridEstoque.Columns[2].Width = 250;
            dataGridEstoque.Columns[3].Width = 250;
            dataGridEstoque.Columns[4].Width = 250;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}

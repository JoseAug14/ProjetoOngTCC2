using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoTcc2
{
    public partial class Telahome : Form
    {
        public Telahome()
        {
            InitializeComponent();
        }

        private void Telahome_Load(object sender, EventArgs e)
        {
            txtcrianca.Text = "Total de crianças atendidas: " + GetTotalChildren().ToString();
            lbldoaca.Text = "Total de Doacao arrecadada: " + GetTotalChildren().ToString();

            DataTable activitiesTable = new DataTable();
            activitiesTable.Columns.Add("Atividade", typeof(string));
            activitiesTable.Columns.Add("Descrição", typeof(string));
            activitiesTable.Columns.Add("Data", typeof(DateTime));

            // Adiciona as atividades ao DataTable
            activitiesTable.Rows.Add("Doação de 100 brinquedos", new DateTime(2024, 10, 1));
            activitiesTable.Rows.Add("Evento de arrecadação", new DateTime(2024, 9, 30));
            activitiesTable.Rows.Add("Cadastrada nova criança", new DateTime(2024, 9, 28));
            activitiesTable.Rows.Add("Voluntário novo se juntou à equipe", new DateTime(2024, 9, 25));
            activitiesTable.Rows.Add("Campanha de Natal iniciada", new DateTime(2024, 9, 20));

            // Configura o DataGridView
            dataGridView1.DataSource = activitiesTable;
            dataGridView1.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato da data

            // Limpa cores de fundo


            dataGridView1.DefaultCellStyle.Font = new Font("Consolas", 9, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;// Define a cor do texto

            // Definindo a altura das linhas (se necessário)
            dataGridView1.RowTemplate.Height = 30; // Ajuste conforme necessário

        }

        private int GetTotalChildren()
        {
            return 120; // Exemplo fixo
        }

        private decimal GetTotalDonations()
        {
            return 5000.00m; // Exemplo fixo
        }

        private void LoadRecentActivities()
        {
            
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo a lista de eventos...");
        }

        private void btnRegisterDonation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo o formulário de doação...");
        }

        private void btneventos_Click(object sender, EventArgs e)
        {
            // Ação para eventos (se necessário)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Outra ação para o botão 2 (se necessário)
        }

        private void listBoxActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ação quando um item é selecionado (se necessário)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
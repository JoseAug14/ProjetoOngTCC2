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
    public partial class AdicionarFamilia : Form
    {
        public AdicionarFamilia()
        {
            InitializeComponent();
        }

        private void gpFilhos_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gpFilhos.Visible = true;
            btncrianca.Visible = true;




        }
        private bool ValidarCPF(string cpf)
        {
            // Remove qualquer máscara (pontos e traços)
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais (ex: 111.111.111-11 não é válido)
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            // Calcula os dígitos verificadores do CPF
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9); // Pega os primeiros 9 dígitos do CPF
            soma = 0;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            // Verifica se os dois dígitos calculados são iguais aos do CPF informado
            return cpf.EndsWith(digito);
        }

       


        private void AdicionarFamilia_Load(object sender, EventArgs e)
        {
            btncrianca.Visible = false;

        }
        private void AbrirFormularioCrianca(int total, int atual)
        {
            if (atual < total) // Verifica se ainda há mais formulários a abrir
            {
                var formularioCrianca = new crianca();

                // Aguarda o fechamento do formulário
                formularioCrianca.ShowDialog();

                // Após o fechamento, abre o próximo
                AbrirFormularioCrianca(total, atual + 1);
            }
        }

        private void btncrianca_Click(object sender, EventArgs e)
        {
            if (filhocombox.SelectedItem != null)
            {
                int quantidade = Convert.ToInt32(filhocombox.SelectedItem);
                AbrirFormularioCrianca(quantidade, 0); // Começa a abrir do índice 0
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Responsavel obj = new Responsavel();

            obj.nome = txtnomeresponsavel.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.telefone = txttelefone.Text;
            obj.email = txtemail.Text;
            obj.endereco = txtrua.Text;
            obj.estadocivil = txtestcivil.Text;
            obj.cidade = txtcidade.Text;
            obj.datanasc = DateTime.Parse(txtdatanasc.Text);
            obj.complemento = txtcomp.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.estado = txtuf.Text;
            obj.cep = txtcep.Text;

            ResponsavelDAO dao = new ResponsavelDAO();
            dao.cadastrarResponsavel(obj);

           
           


            string cpfDigitado = txtcpf.Text.Trim(); // Pega o CPF que o usuário digitou

            // Verifica se o CPF é válido
            if (ValidarCPF(cpfDigitado))
            {

            }
            else
            {
                MessageBox.Show("CPF inválido.", "Verificação");
            }





        }
    }
}


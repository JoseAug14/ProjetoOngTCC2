using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ProjetoTcc2
{
    public partial class TelaLogin : Form
    {
        private readonly string chaveSecreta = "b14ca5898a4e4133bbce2ea2315a1916"; // Chave de 32 caracteres
        private bool estaCriptografando = false; // Variável de controle para evitar loop infinito

        public TelaLogin()
        {
            InitializeComponent();
            txtsenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = "admin";
            int senha = 727272;

            user = txtuser.Text;
            senha=int.Parse(txtsenha.Text);

            
            if (senha == 727272 && user == "admin")
            {
                TelaInicial telainicial = new TelaInicial();

                telainicial.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario ou senha incorreto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            // Verifica se já está em processo de criptografia para evitar loop
            if (!estaCriptografando)
            {
                estaCriptografando = true;

                // Obtém o texto que o usuário digitou
                string textoOriginal = txtsenha.Text;

                // Criptografa o texto
                string textoCriptografado = Criptografar(textoOriginal, chaveSecreta);

                // Atualiza o conteúdo da TextBox com o texto criptografado
                txtsenha.Text = textoCriptografado;

                // Move o cursor para o final
                txtsenha.SelectionStart = txtsenha.Text.Length;
                estaCriptografando = false;
            }
        }
        public static string Criptografar(string texto, string chave)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto; // Se o texto estiver vazio, não criptografa

            byte[] chaveBytes = Encoding.UTF8.GetBytes(chave);
            byte[] iv = new byte[16];
            byte[] textoBytes = Encoding.UTF8.GetBytes(texto);

            using (Aes aes = Aes.Create())
            {
                aes.Key = chaveBytes;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(textoBytes, 0, textoBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }





        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}

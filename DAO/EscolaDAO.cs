using MySql.Data.MySqlClient;
using ProjetoTcc2.Conexao;
using ProjetoTcc2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc2.DAO
{
    public class EscolaDAO
    {

        Crianca crianca = new Crianca();

        private MySqlConnection conexao;
        public EscolaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarEscola(Crianca obj)
        {


            try
            {
                string sql = @"insert into escola(nome, telefone)values(@nome,@telefone)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nomeescola);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefoneescola);

                conexao.Open();
                executacmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("erro:" + erro);
            }
        }
    }
}

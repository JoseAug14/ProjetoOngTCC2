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
    public class CriancaDAO
    {
        
        private MySqlConnection conexao;
        public CriancaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarCrianca

        public void cadastrarCrianca(Crianca obj)
        {

            try
            {
                string sql = @"insert into crianca(nome,data_nascimento,tamanho,serie,frequencia,media_notas,id_responsavel,id_escola)
                               values(@nome,@data_nascimento,@tamanho,@serie,@frequencia,@media_notas,@id_responsavel,@id_escola)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome@", obj.nomecrianca) ;
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.nomecrianca);
                executacmd.Parameters.AddWithValue("@tamanho", obj.nomecrianca);
                executacmd.Parameters.AddWithValue("@serie", obj.nomecrianca);
                executacmd.Parameters.AddWithValue("@frequencia", obj.nomecrianca);
                executacmd.Parameters.AddWithValue("@media_notas", obj.nomecrianca);
                executacmd.Parameters.AddWithValue("@id_responsavel", obj.idResponsavel);
                executacmd.Parameters.AddWithValue("@id_escola", obj.idEscola );

                conexao.Open();
                executacmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao cadastrar crianca" + erro);
            }
        }



        #endregion
    }
}

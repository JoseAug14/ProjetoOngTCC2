using MySql.Data.MySqlClient;
using ProjetoTcc2.Conexao;
using ProjetoTcc2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTcc2.DAO
{
    public class ResponsavelDAO
    {

        private MySqlConnection conexao;
        public ResponsavelDAO() 
        { 
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarResponsavel
        public void cadastrarResponsavel(Responsavel obj)
        {
            
             

                try
                {
                    string sql = @"INSERT INTO responsavel (nome, cpf, rg, telefone, email, data_nascimento, endereco, estado_civil, cidade, estado, numero, cep, complemento)
                       VALUES (@nome, @cpf, @rg, @telefone, @email, @data_nascimento, @endereco, @estado_civil, @cidade, @estado, @numero, @cep, @complemento)";

                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", obj.nome);
                    executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                    executacmd.Parameters.AddWithValue("@rg", obj.rg);
                    executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                    executacmd.Parameters.AddWithValue("@email", obj.email);
                    executacmd.Parameters.AddWithValue("@data_nascimento", obj.datanasc);
                    executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                    executacmd.Parameters.AddWithValue("@estado_civil", obj.estadocivil);
                    executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                    executacmd.Parameters.AddWithValue("@estado", obj.estado);
                    executacmd.Parameters.AddWithValue("@numero", obj.numero);
                    executacmd.Parameters.AddWithValue("@cep", obj.cep);
                    executacmd.Parameters.AddWithValue("@complemento", obj.complemento);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso");
                   
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar responsável: " + erro.Message);
                     
                }
                finally
                {
                    conexao.Close();
                }
               
            }
        #endregion
        #region listarResponsavel
        public DataTable listarResponsavel()
        {
            try
            {
                DataTable tabelaresponsavel = new DataTable();

                string sql = "select * from responsavel";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaresponsavel);


                return tabelaresponsavel;

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro ao executar o comando " + erro);
                return null;
            }
            

        }



        #endregion



        #region alterarResponsavel
        public void alterarCliente(Responsavel obj)
        {
            try
            {
                string sql = @"UPDATE responsavel (nome=@nome, cpf=@cpf, rg=@rg, telefone=@telefone, email=@email, data_nascimento=@data_nascimento, endereco=@endereco, estado_civil=@estado_civil, cidade=@cidade, estado=@estado, numero=@numero, cep=@cep, complemento=@complemento)
                       WHERE id =@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.datanasc);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@estado_civil", obj.estadocivil);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@id", obj.complemento);

                conexao.Open();
                executacmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion
    }
}


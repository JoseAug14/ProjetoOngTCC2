using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTcc2.Conexao
{
    public class ConnectionFactory
    {

        public MySqlConnection getconnection() 
        { 

            string conexao = ConfigurationManager.ConnectionStrings["bdong"].ConnectionString;

            return new MySqlConnection(conexao);
        
        }
    }
}

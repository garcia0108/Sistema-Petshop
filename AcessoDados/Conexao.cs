using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjPetShop_2

{
    public class Conexao
    {
        //Atribuição que é a String de Conexão.
        private static string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Construcao;Integrated Security=True";

        //Método acessor de leitura da String de Conexão.
        public static string stringConexao
        {
            get { return conexao; } 
        }
    }
}
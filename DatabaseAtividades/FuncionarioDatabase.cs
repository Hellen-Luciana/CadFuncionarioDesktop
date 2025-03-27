using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAtividades
{
    public class FuncionarioDatabase
    {
        private string connectionString;
        public FuncionarioDatabase()
        {
            connectionString = ConfigurationManager.AppSettings["SQLconnection"];

        }

        public void Salvar(string nome, int idade, string cpf)
        {
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                string queryString = $"insert into Funcionarios (Nome,Idade,cpf, DataHora) values ('{nome}','{idade}','{cpf}', '{DateTime.Now}');";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();


            }

        }

        public DataTable Mostrar()
        {
            var dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                string queryString = $"Select * From Funcionarios ;";

                using (SqlDataAdapter da = new SqlDataAdapter(queryString, connection))
                {
                    da.Fill(dt);
                }

            }
            return dt;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private static Connection instance;

        private string connectionString = @"Data Source=LAPTOP-JF5A2FAK;Initial Catalog=KARAOKEMANAGEMENT;Integrated Security=True;Encrypt=False";
        
        public static Connection Instance
        {
            get {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }

            private set { instance = value; }
        }

        private Connection() { }

        public DataTable SelectQuery(string query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach(string param in listParameter)
                    {
                        if(param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public int actionQuery(string query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParameter)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public string executeScalar(string query)
        {
            string returnData;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if(command.ExecuteScalar() != null)
                {
                    returnData = command.ExecuteScalar().ToString();
                }
                else
                {
                    returnData = null;
                }
                connection.Close();
            }
            return returnData;
        }
    }
}

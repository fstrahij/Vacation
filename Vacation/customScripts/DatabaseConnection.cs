using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private string ConnectionString = "Data Source=127.0.0.1;user id=sa;password=newpassword;Initial Catalog=Vacation;";

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public DataTable DohvatiPodatke(string sqlUpit)
        {
            DataTable results = new DataTable();
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(sqlUpit, Connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    Connection.Open();
                    adapter.Fill(results);
                }
                catch (Exception)
                {

                    Console.WriteLine("Povezivanje s bazom nije uspjelo!");
                }
            }
            return results;
        }

        public void IzvrsiUpit(string sqlUpit)
        {
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(sqlUpit, Connection))
            {
                try
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    Console.WriteLine("Povezivanje s bazom nije uspjelo!");
                }
            }
        }
    }
}

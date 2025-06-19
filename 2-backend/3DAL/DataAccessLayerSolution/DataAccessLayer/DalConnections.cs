using System;
using System.Data;
using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DalConnections {

    public class DalConnections {

        #region PRIVATE_VARIABLES
        private string connectionString = $@"Server=(localdb)\MSSQLLocalDB;Database=VERAS_MUSIC_PROJECT_DB;Trusted_Connection=True;";
        #endregion

        /// <summary>
        /// SELECT
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        protected DataTable Select(string query) {

            try {

                var outParam = new DataTable();

                using(SqlConnection connection = new SqlConnection(connectionString)) {

                    try {

                        connection.Open();

                        using(SqlCommand command = new SqlCommand(query, connection))
                        using(SqlDataAdapter adapter = new SqlDataAdapter(command)) { adapter.Fill(outParam); }

                    } catch(Exception) {

                        throw;
                    }
                }

                return outParam;

            } catch(Exception) {

                throw;
            }
        }

        protected string Get(string query) {

            try {

                string outParam = string.Empty;

                using(SqlConnection connection = new SqlConnection(this.connectionString)) {

                    SqlCommand command = new SqlCommand(query,connection);
                    
                    using(SqlDataReader reader = command.ExecuteReader()) {

                        outParam = reader[0].ToString();

                    }

                };

                return outParam;

            } catch(Exception) {

                throw;
            }

        }

        protected void ExecuteQuery(string query) {

            try {

                using(SqlConnection connection = new SqlConnection(this.connectionString)) {

                    try {

                        connection.Open();

                        using(SqlCommand command = new SqlCommand(query,connection)) {

                            Console.WriteLine("Comando executado com sucesso!");
                            command.ExecuteNonQuery();
                        }

                    } catch(Exception) {

                        Console.WriteLine("Algo de errado!");
                        throw;
                    }
                }

            } catch(Exception) {

                throw;
            }

        }

        protected int BooleanFormat(bool value) {

            if(value)
                return 1;
            else
                return 0;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace DAL.agendarCalendar
{
    public class DataAccess
    {
        private string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";
        // Sua string de conexão com o banco de dados
        [Serializable]
        public class User
        {
            public int HorarioID { get; set; }
            public DateTime DataAgenda { get; set; }
            public TimeSpan Hora { get; set; }
            public bool Disponivel { get; set; }
        }

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Exemplo de método para consultar dados do banco de dados
        public List<User> GetHorarios()
        {
            List<User> horariosList = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT HorarioID, DataAgenda, Hora, Disponivel FROM Horarios WHERE Disponivel = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User horario = new User
                            {
                                HorarioID = Convert.ToInt32(reader["HorarioID"]),
                                DataAgenda = Convert.ToDateTime(reader["DataAgenda"]),
                                Hora = TimeSpan.Parse(reader["Hora"].ToString()),
                                Disponivel = Convert.ToBoolean(reader["Disponivel"])
                            };

                            horariosList.Add(horario);
                        }
                    }
                }
            }

            return horariosList;
        }
        public List<User> GetHorariosPorData(DateTime dataSelecionada)
        {
            List<User> horariosList = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    // Use BETWEEN para comparar o intervalo de 24 horas do dia selecionado
                    string query = "SELECT HorarioID, DataAgenda, Hora, Disponivel " +
                                   "FROM Horarios " +
                                   "WHERE DataAgenda BETWEEN @DataAgendaInicio AND @DataAgendaFim AND Disponivel = 1";

                    DateTime dataSelecionadaInicio = dataSelecionada.Date;
                    DateTime dataSelecionadaFim = dataSelecionada.Date.AddDays(1).AddSeconds(-1); // Último segundo do dia

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataAgendaInicio", dataSelecionadaInicio);
                        command.Parameters.AddWithValue("@DataAgendaFim", dataSelecionadaFim);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User horario = new User
                                {
                                    HorarioID = Convert.ToInt32(reader["HorarioID"]),
                                    DataAgenda = Convert.ToDateTime(reader["DataAgenda"]),
                                    Hora = TimeSpan.Parse(reader["Hora"].ToString()),
                                    Disponivel = Convert.ToBoolean(reader["Disponivel"])
                                };

                                horariosList.Add(horario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Trate a exceção conforme necessário
                }
            }

            return horariosList;
        }

        
    }
    // Outros métodos para executar inserções, atualizações, deleções, etc.
}

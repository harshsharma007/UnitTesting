using Microsoft.AspNetCore.Components;
using System.Data.SqlClient;

namespace MockDatabase.Data
{
    public class NoMoqableService
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private readonly IConfiguration _configuration;

        public NoMoqableService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<WeatherForecast>> GetForecastNoMoqableAsync(DateTime startDate)
        {
            var data = await Task.Run(() =>
            {
                string connectionString = _configuration.GetConnectionString("Wheater");
                using SqlConnection sqlConnection = new SqlConnection(connectionString);
                using SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM WeatherInfo WHERE Date = @Date";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@Date", startDate);

                List<WeatherForecast> weatherForecasts = new();
                sqlConnection.Open();
                try
                {
                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        WeatherForecast weatherForecast = new WeatherForecast()
                        {
                            DateTime = Convert.ToDateTime(reader["Date"]),
                            Summary = Convert.ToString(reader["Summary"]),
                            TemperatureC = Convert.ToInt32(reader["Temperature"])
                        };
                        weatherForecasts.Add(weatherForecast);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    this.NavigationManager.NavigateTo("Error", true);
                }

                return weatherForecasts;
            });

            return data;
        }
    }
}

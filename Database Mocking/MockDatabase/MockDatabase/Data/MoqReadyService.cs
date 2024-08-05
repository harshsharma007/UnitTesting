using System.Data;
using System.Data.SqlClient;

namespace MockDatabase.Data
{
    public class MoqReadyService : IMoqReadyService
    {
        // Factory for IDb Connection
        private Func<IDbConnection> _connectionFactory { get; }

        public MoqReadyService(Func<IDbConnection> connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<WeatherForecast>> GetForecastMoqableAsync(DateTime startDate)
        {
            var data = await Task.Run(() =>
            {
                using IDbConnection dbConnection = this._connectionFactory.Invoke();
                using IDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = "SELECT * FROM WeatherInfo WHERE Date = @Date";
                dbCommand.Parameters.Clear();
                dbCommand.Parameters.Add(new SqlParameter("@Date", System.Data.SqlDbType.DateTime) { Value = startDate });

                List<WeatherForecast> weatherForecasts = new();
                dbConnection.Open();
                try
                {
                    using IDataReader dataReader = dbCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        WeatherForecast weatherForecast = new WeatherForecast()
                        {
                            DateTime = Convert.ToDateTime(dataReader["Date"]),
                            Summary = Convert.ToString(dataReader["Summary"]),
                            TemperatureC = Convert.ToInt32(dataReader["Temperature"])
                        };
                        weatherForecasts.Add(weatherForecast);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }

                return weatherForecasts;
            });

            return data;
        }

        public async Task<int> SetForecastAsync(WeatherForecast forecast)
        {
            var data = await Task.Run(() =>
            {
                using IDbConnection dbConnection = this._connectionFactory.Invoke();
                using IDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = @"INSERT INTO WeatherInfo (Date, Summary, Temperature) VALUES @Date, @Summary, @TemperatureC";
                dbCommand.Parameters.Clear();
                dbCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = forecast.DateTime });
                dbCommand.Parameters.Add(new SqlParameter("@Summary", SqlDbType.VarChar) { Value = forecast.Summary });
                dbCommand.Parameters.Add(new SqlParameter("TemperatureC", SqlDbType.Int) { Value = forecast.TemperatureC });

                dbConnection.Open();
                int rows = 0;
                try
                {
                    rows = dbCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }

                return rows;
            });

            return data;
        }
    }
}

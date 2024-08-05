namespace MockDatabase.Data
{
    public interface IMoqReadyService
    {
        Task<List<WeatherForecast>> GetForecastMoqableAsync(DateTime startDate);
        Task<int> SetForecastAsync(WeatherForecast forecast);
    }
}

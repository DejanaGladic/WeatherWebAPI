using WeatherWebAPI.Data;

namespace WeatherWebAPI.Interfaces
{
    public interface IWeatherRepository
    {
        List<Weather> GetAll();
        List<Weather> GetByCountry(string countryName);
        void PostNewWeather(Weather weather);

        List<Weather> GetByCityAndCountry(string cityName, string countryName);
        void DeleteWeatherByCityAndCountry(string cityName, string countryName);
    }
}

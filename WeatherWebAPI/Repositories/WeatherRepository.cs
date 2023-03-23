using WeatherWebAPI.Data;
using WeatherWebAPI.Interfaces;

namespace WeatherWebAPI.Repositories
{
    public class WeatherRepository: IWeatherRepository
    {

        public List<Weather> GetAll()
        {
            return Database.weather;
        }

        public List<Weather> GetByCountry(string countryName)
        {
            var weatherByCountry = Database.weather
                .FindAll(weatherByCity => weatherByCity.Country.Equals(countryName));
            return weatherByCountry;
        }

        public void PostNewWeather(Weather weather)
        {
            Database.weather.Add(weather);
        }

        public void DeleteWeatherByCityAndCountry(string cityName, string countryName)
        {
            var weathers = GetByCityAndCountry(cityName,countryName);
            weathers.ForEach(weather => Database.weather.Remove(weather));
        }

        public List<Weather> GetByCityAndCountry(string cityName, string countryName)
        {
            var weathers = Database.weather
                .FindAll(weather => weather.City.Equals(cityName) && weather.Country.Equals(countryName));
            return weathers;
        }
    }
}

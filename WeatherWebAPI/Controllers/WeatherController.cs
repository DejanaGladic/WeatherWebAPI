using Microsoft.AspNetCore.Mvc;
using WeatherWebAPI.Data;
using WeatherWebAPI.Interfaces;

namespace WeatherWebAPI.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        public IWeatherRepository weatherRepository;

        public WeatherController(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        [HttpGet()]
        public ActionResult<List<Weather>> GetAllWeathers()
        {
            var data = weatherRepository.GetAll();
            return Ok(data);
        }

        [HttpGet()]
        [Route("{countryName}")]
        public ActionResult GetWeathersByCity(string countryName)
        {
            var data = weatherRepository.GetByCountry(countryName);
            if (data.Count() == 0)
                return NoContent();
            return Ok(data);
        }

        //Delete i Post urade sta treba,ali sa sledecom Get naredbom se to ponisti
        //zato sam listu u Database klasi kreirala kao staticku
        [HttpPost()]
        public ActionResult PostWeather(Weather weather)
        {
            weatherRepository.PostNewWeather(weather);
            return Created("weather","New weather is added to list");
        }

        [HttpDelete()]
        [Route("{countryName}/{cityName}")]
        public ActionResult DeleteWeatherByCityAndCountry(string cityName, string countryName)
        {
            var data = weatherRepository.GetByCityAndCountry(cityName,countryName);
            if (data.Count() == 0)
                return NoContent();
            weatherRepository.DeleteWeatherByCityAndCountry(cityName, countryName);
            return Ok("Weather has been deleted");
        }
    }
}

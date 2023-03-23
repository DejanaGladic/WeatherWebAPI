namespace WeatherWebAPI.Data
{
    public class Weather
    {
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public decimal Temperature { get; set; }
        public decimal WindSpeed { get; set; }

        public Weather()
        {
        }
        public Weather(string country, int zipCode, string city, decimal temperature, decimal windSpeed)
        {
            Country = country;
            City = city;
            Temperature = temperature;
            WindSpeed = windSpeed;
            ZipCode = zipCode;
        }
    }
}

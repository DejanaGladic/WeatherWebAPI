namespace WeatherWebAPI.Data
{
    public class Database
    {
        public static List<Weather> weather = new List<Weather> {
            new Weather("Serbia", 21000, "Novi Sad", 8, 2.68M),
            new Weather("Serbia", 11000, "Belgrade", 17, 3.13M),
            new Weather("Germany", 80335, "Munich", 24, 3.6M),
            new Weather("Sweden", 10316, "Stockholm", 4, 5.81M),
            new Weather("UK", 56273, "London", 2, 1.54M),
            new Weather("France", 70213, "Paris", 27, 2.68M),
            new Weather("Italy", 30100, "Venice", 17, 2.24M),
            new Weather("Italy", 20019, "Milano", 19, 0.89M),
            new Weather("Serbia", 23000, "Zrenjanin", 9, 0.51M),
            new Weather("Netherland", 10110, "Amsterdam", 9, 4.12M)};
    }
}

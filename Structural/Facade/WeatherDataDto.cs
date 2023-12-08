namespace Facade.Facade
{
    public class WeatherDataDto
    {
        public int Fahrenheit { get; set; }
        public int Celcius { get; set; }
        public string CityName { get; set; } = "";
        public string State { get; set; } = "";
    }
}
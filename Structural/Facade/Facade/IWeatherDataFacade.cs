namespace Facade.Facade
{
    public interface IWeatherDataFacade
    {
        public WeatherDataDto GetWeatherDataForZipcode(string zipCode);
    }

    public class WeatherDataFacade : IWeatherDataFacade
    {
        private GeoLookupService geoLookupService;
        private WeatherService weatherService;
        private ConverterService converterService;

        public WeatherDataFacade()
        {
            this.geoLookupService = new GeoLookupService();
            this.weatherService = new WeatherService();
            this.converterService = new ConverterService();
        }

        public WeatherDataDto GetWeatherDataForZipcode(string zipCode)
        {
            City city = this.geoLookupService.GetCityForZipCode(zipCode);
            State state = this.geoLookupService.GetStateForZipCode(zipCode);

            int fahrenheit = this.weatherService.GetTempFahrenheit(city, state);

            int celcius = this.converterService.ConvertFahrenheitToCelcious(fahrenheit);

            return new WeatherDataDto()
            {
                Celcius = celcius,
                Fahrenheit = fahrenheit,
                CityName = city.Name,
                State = state.Name
            };
        }
    }
}

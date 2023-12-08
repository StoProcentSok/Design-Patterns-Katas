using Facade;
using Facade.Facade;
using System.Formats.Asn1;

public class Program
{
    private static void Main(string[] args)
    {
        //var bigCassFacade = new BigClassFacade();
        //var result = bigCassFacade.DoOperations();

        //Console.WriteLine($"Final Number : {result}");

        const string zipCode = "98074";

        // call to service 1
        GeoLookupService geoLookupService = new GeoLookupService();
        City city = geoLookupService.GetCityForZipCode(zipCode);
        State state = geoLookupService.GetStateForZipCode(zipCode);

        // call to service 2
        WeatherService weatherService = new WeatherService();
        int fahrenheit = weatherService.GetTempFahrenheit(city, state);

        // call to service 3
        ConverterService metricConverter = new ConverterService();
        int celcius = metricConverter.ConvertFahrenheitToCelcious(fahrenheit);

        // bring the result of all service calls together
        Console.WriteLine("The current temperature is {0} F / {1} C in {2}, {3}",
                            fahrenheit,
                            celcius,
                            city.Name,
                            state.Name);

    }
}
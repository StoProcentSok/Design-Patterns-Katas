using Facade.Facade;

public class Program
{
    private static void Main(string[] args)
    {
        const string zipCode = "98074";

        var weatherDataFacade = new WeatherDataFacade();
        var result = weatherDataFacade.GetWeatherDataForZipcode(zipCode);

        Console.WriteLine("The current temperature is {0} F / {1} C in {2}, {3}",
                            result.Fahrenheit,
                            result.Celcius,
                            result.CityName,
                            result.State);

    }
}
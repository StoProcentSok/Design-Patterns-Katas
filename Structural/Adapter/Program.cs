using Adapter;
using ClassAdapter;

Console.Title = "Adapter";

Adapter.ICityAdapter adapter = new CityAdapter();

var city = adapter.GetCity();
Console.WriteLine($"{city.FullName}, {city.Inhabitants}");

Console.ReadLine();
using Facade;
using Facade.Facade;
using System.Formats.Asn1;

public class Program
{
    private static void Main(string[] args)
    {
        var bigCassFacade = new BigClassFacade();
        var result = bigCassFacade.DoOperations();

        Console.WriteLine($"Final Number : {result}");
    }
}
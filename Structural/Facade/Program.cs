using Facade;
using Facade.Facade;
using System.Formats.Asn1;

public class Program
{
    private static void Main(string[] args)
    {
        var bigCassFacade = new BigClassFacade();
        var result = bigCassFacade.DoOperations();
        BigClass bigClass = new BigClass();

        bigClass.SetValueI(3);

        bigClass.IncrementI();
        bigClass.IncrementI();
        bigClass.IncrementI();

        bigClass.DecrememntI();


        Console.WriteLine($"Final Number : {result}");
    }
}
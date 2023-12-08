using Facade;
using System.Formats.Asn1;

public class Program
{
    private static void Main(string[] args)
    {
        BigClass bigClass = new BigClass();

        bigClass.SetValueI(3);

        bigClass.IncrementI();
        bigClass.IncrementI();
        bigClass.IncrementI();

        bigClass.DecrememntI();

        Console.WriteLine($"Final Number : {bigClass.GetValueB()}");
    }
}
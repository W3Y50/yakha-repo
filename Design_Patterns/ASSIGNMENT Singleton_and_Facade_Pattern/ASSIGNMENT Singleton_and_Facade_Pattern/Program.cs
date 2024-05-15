// Client code
using ASSIGNMENT_Singleton_and_Facade_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        var orderDetails = new OrderDetails
        {
            ProductId = 123,
            ProductName = "A small book on about birds",
            Cost = 50,
            Quantity = 100,
            AddressLine1 = "Street No 1",
            AddressLine2 = "Educational Area in Jena",
            PinCode = 1234,
            CardNumber = "415621375439"
        };

        var facade = new OnlineShoppingFacade();
        facade.FinalizeOrder(orderDetails);

        Console.ReadLine();
    }
}
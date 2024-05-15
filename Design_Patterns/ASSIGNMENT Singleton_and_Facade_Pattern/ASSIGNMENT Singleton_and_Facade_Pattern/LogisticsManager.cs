using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    // Subsystem1 for shipping logistics
    public interface ILogistics
    {
        void ShipProduct(string productName, string shippingAddress);
    }

    public class LogisticsManager : ILogistics
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine($"Congratulations, your product {productName} has been shipped to {shippingAddress}.");
        }
    }
}

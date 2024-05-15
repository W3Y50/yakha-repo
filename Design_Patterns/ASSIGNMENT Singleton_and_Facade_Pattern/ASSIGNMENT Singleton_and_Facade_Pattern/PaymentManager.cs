using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    // Subsystem2 for payment processing
    public interface IPaymentProcessor
    {
        bool ProcessPayment(string cardNo, float cost);
    }

    public class PaymentManager : IPaymentProcessor
    {
        public bool ProcessPayment(string cardNo, float cost)
        {
            Console.WriteLine($"Card# {cardNo} is used to make a payment of {cost}.");
            return true;
        }
    }
}

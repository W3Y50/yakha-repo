using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    // Subsystem3 for order verification
    public interface IOrderVerify
    {
        bool Verify(OrderDetails orderDetails);
    }

    public class OrderVerificationManager : IOrderVerify
    {
        public bool Verify(OrderDetails orderDetails)
        {
            Console.WriteLine($"Verifying order for {orderDetails.ProductName}.");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    // Subsystem4 for inventory management
    public interface IInventory
    {
        void Update(int productId);
    }

    public class InventoryManager : IInventory
    {
        public void Update(int productId)
        {
            Console.WriteLine($"Product# {productId} is updated in the inventory.");
        }
    }
}

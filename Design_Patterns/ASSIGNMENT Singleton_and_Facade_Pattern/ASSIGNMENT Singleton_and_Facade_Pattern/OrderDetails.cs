using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    //
    public class OrderDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Cost { get; set; }
        public int Quantity { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int PinCode { get; set; }
        public string CardNumber { get; set; }
    }
}

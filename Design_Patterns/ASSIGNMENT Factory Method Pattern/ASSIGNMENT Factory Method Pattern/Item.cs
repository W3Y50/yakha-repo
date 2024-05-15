using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Factory_Method_Pattern
{
    // Product (Abstract Class)
    public abstract class Item
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public abstract void UseItem();
    }
}

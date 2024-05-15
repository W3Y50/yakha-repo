using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Factory_Method_Pattern
{
    public class Shield : Item
    {
        public int DefenseValue { get; set; }

        public override void UseItem()
        {
            Console.WriteLine($"Using a Shield with Defense Value: {DefenseValue}");
        }
    }
}

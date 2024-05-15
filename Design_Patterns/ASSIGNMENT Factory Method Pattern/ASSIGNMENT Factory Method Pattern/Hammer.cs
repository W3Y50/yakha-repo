using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Factory_Method_Pattern
{
    public class Hammer : Item
    {
        public int AttackValue { get; set; }

        public override void UseItem()
        {
            Console.WriteLine($"Using a Hammer with Attack Value: {AttackValue}");
        }
    }
}

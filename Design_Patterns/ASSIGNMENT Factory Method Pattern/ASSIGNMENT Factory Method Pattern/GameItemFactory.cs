using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Factory_Method_Pattern
{
    // Creator (Abstract Class)
    public abstract class ItemFactory
    {
        public abstract Item CreateRandomItem();
    }

    public class GameItemFactory : ItemFactory
    {
        private static Random random = new Random();

        public override Item CreateRandomItem()
        {
            int randomNumber = random.Next(1, 3);
            if (randomNumber == 1)
            {
                return CreateShield();
            }
            else
            {
                return CreateHammer();
            }
        }

        private Item CreateShield()
        {
            Shield shield = new Shield
            {
                Name = "Awesome Shield",
                Id = random.Next(1, 101),
                DefenseValue = random.Next(10, 21)
            };
            return shield;
        }

        private Item CreateHammer()
        {
            Hammer hammer = new Hammer
            {
                Name = "Slash Hammer",
                Id = random.Next(1, 101),
                AttackValue = random.Next(15, 26)
            };
            return hammer;
        }
    }
}

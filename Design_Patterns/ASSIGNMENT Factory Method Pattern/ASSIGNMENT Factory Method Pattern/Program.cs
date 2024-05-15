using ASSIGNMENT_Factory_Method_Pattern;
using System;


// Concrete Items

/*
public class Shield: Item
{
    int defenseValue = 0;

    public override Item CreateID(int itemid)
    {
        return this.CreateID(itemid);
    }

    public override Item CreateName(string itemname)
    {
        return this.CreateName(itemname);
    }

    public override void UseItem(Item itemname)
    {
        Console.WriteLine(itemname + " is generated!");
    }
}

public class Hammer : Item
{
    int attackValue = 0;

    public override Item CreateID(int itemid)
    {
        return this.CreateID(itemid);
    }

    public override Item CreateName(string itemname)
    {
        return this.CreateName(itemname);
    }

    public override void UseItem(Item itemname)
    {
        Console.WriteLine(itemname + " is generated!");
    }
}

// Creator abstract class
public abstract class Item
{
    public abstract Item CreateName(string itemname);
    public abstract Item CreateID(int itemid);
    public abstract void UseItem(Item itemname);

}

// Concrete Creator
public class ConcreteItemFactory: Item
{
    public override Item CreateName(string itemname)
    {
        if (itemname.Equals("Shield", StringComparison.OrdinalIgnoreCase))
        {
            return new Shield();
        }
        else if (itemname.Equals("Hammer", StringComparison.OrdinalIgnoreCase))
        {
            return new Hammer();
        }
        else
        {
            //throw new ArgumentException($"Upppsi");
            return null;
        }
    }

    public override Item CreateID(int itemid)
    {
        return this.CreateID(itemid);
    }

    public override void UseItem(Item itemname)
    {
        Console.WriteLine(itemname + " is generated!");
    }

}

// Client code
public class Program
{
    public static void Main(string[] args)
    {
        ConcreteItemFactory factory = new ConcreteItemFactory();

        Item shield = factory.CreateName("Shield");
        shield.UseItem(shield); // Output: Drawing a Shield

        Item hammer = factory.CreateName("Hammer");
        shield.UseItem(hammer); // Output: Drawing a Hammer

    }
}
*/


// Client Code
public class Program
{
    public static void Main(string[] args)
    {
        ItemFactory factory = new GameItemFactory();

        Item item1 = factory.CreateRandomItem();
        item1.UseItem();

        Item item2 = factory.CreateRandomItem();
        item2.UseItem();

        Item item3 = factory.CreateRandomItem();
        item3.UseItem();
    }
}
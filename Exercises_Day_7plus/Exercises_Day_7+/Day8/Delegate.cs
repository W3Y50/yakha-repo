using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises_Day_7_.Day8
{

    delegate void Operations(int x, int y); //Note: no overloding with Delegates!
    internal class Delegates
    {
        public static void Main(string[] args)
        {
            Operations del = Add;
            del += Subtract;
            ProceedtheLogic pro = new ProceedtheLogic();
            pro.StartProceeding();
            del(10, 5); // Invokes both Add and Subtract methods

            // Subscribe to the event
            Button.Click += EventHandlerExample.ButtonClickHandler;

            // Simulate a button click
            Button.SimulateClick();

            //RexEx tests

            RegExThings reg = new RegExThings();
            Console.WriteLine("Enter a Text. The pattern is: format of 28-JUL-2023");
            Console.WriteLine("The RegEx is matched: " + reg.RegExIsMatched(Console.ReadLine()));

            //ChristmasTest
            ChristmasTest.HandOutGift("Peter");
            ChristmasTest.HandOutGift("Marie");
            ChristmasTest.HandOutGift("Bernd");
            ChristmasTest.HandOutGift("Frank");
            ChristmasTest.HandOutGift("Louis");
            ChristmasTest.HandOutGift("Peter"); //must throw an Error

            //Find the highest and the lowest number in a string

            Console.WriteLine("The highest and the lowest number is: " + ChristmasTest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

        }
        static void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }

        static void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }

    }

}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Character_Class_Assignment
{
    public class Backpack
    {
        string Color;
        string Size;
        List<string> Items = new List<string>();
        bool Open = false;

        public Backpack(string size, string color)
        { 
            Size = size;
            Color = color;
        }

        public void openBag()
        {
            Open = true;
            Console.WriteLine("Bag is now opened.");
        }

        public void closeBag()
        {
            Open = false;
            Console.WriteLine("Bag is now closed");
        }

        public void putIn(string item)
        {
            if (Open == true)
            {
                Items.Add(item);
                Console.WriteLine(item + " has been added!");
                Console.WriteLine("In the " + Color + " " + Size + " bag, here are all the items you have put into it: ");
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine(Items[i]);
                }
            }
        }

        public void takeOut(string item)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Open == true && Items[i] == item)
                {
                    Items.Remove(item);
                    Console.WriteLine(item + " has been removed!");
                    Console.WriteLine("In the " + Color + " " + Size + " bag, here are all the items you have put into it: ");
                    for (int i2 = 0; i2 < Items.Count; i2++)
                    {
                        Console.WriteLine(Items[i2]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Backpack schoolBag = new Backpack("small", "blue");
            Backpack workBag = new Backpack("medium", "red");
            Backpack gymBag = new Backpack("large", "green");

            schoolBag.openBag();
            schoolBag.putIn("my lunch");
            schoolBag.putIn("my jacket");
            schoolBag.closeBag();
            schoolBag.openBag();
            schoolBag.takeOut("my jacket");
            schoolBag.closeBag();
        }
    }
}

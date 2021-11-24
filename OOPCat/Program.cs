using System;

namespace OOPCat
{
    class Program
    {
        class cat
        {
            string name;
            string color;
            double hungriness;

            public cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"The cat {name} has been created");
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hungriness
            {
                get { return hungriness; }
            }

            public void sleeps()
            {
                Console.WriteLine("z-z-z-z-z");
                hungriness += 0.2;
            }

            public void meow()
            {
                Console.WriteLine($"{name} says \"Meow!\"");
            }


        }
        static void Main(string[] args)
        {
            cat myCat = new cat("Garfield", "ginger");

            while(myCat.Hungriness != 1)
            {
                myCat.sleeps();
            }

            myCat.meow();
        }
    }
}

using System;

public class Program
{
    public static void Main()
    {
        {
            string runagain = "yes";
            while (runagain == "yes" || runagain == "y")
            {
                Console.WriteLine("How many people are we making PB and J sandwiches for?");
                int people = int.Parse(Console.ReadLine());
                decimal breadslice = people * 2;
                decimal peanutbutter = people * 2;
                decimal jelly = people * 4;
                decimal loaf = breadslice / 28;
                decimal jarPB = peanutbutter / 32;
                decimal jarJelly = jelly / 48;
                Console.WriteLine(breadslice + " slices of bread");
                Console.WriteLine(peanutbutter + " tablespoons of peanut butter");
                Console.WriteLine(jelly + " teaspoons of jelly");
                Console.WriteLine("which is ...");
                Console.WriteLine(Math.Ceiling(loaf) + " loaves of bread");
                Console.WriteLine(Math.Ceiling(jarPB) + " jars of peanut butter");
                Console.WriteLine(Math.Ceiling(jarJelly) + " jars of jelly");
                Console.WriteLine("Would you like to restart? Enter Yes or y to continue, or enter any other key to exit.");
                runagain = (Console.ReadLine());
                if (runagain != "yes" && runagain != "y")
                    Console.WriteLine("Goodbye");
                else
                {
                }
            }
        }
    }
}
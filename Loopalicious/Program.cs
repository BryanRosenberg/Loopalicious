using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// while loop
// while(condition)



namespace Loopalicious
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Infinity");
                break;
            }

            Console.WriteLine("Would you like me to stop?");
            string choice = Console.ReadLine();

            while (choice != "yes")
            {
                Console.WriteLine("Would you like me to stop?");
                choice = Console.ReadLine();
            }

            int[] roll = new int[5]; //new keyword creates instances
            for(int i = 0; i < roll.Length; i += 1)
            {
                roll[i] = i + 1;
            }

            for(int i = 0; i < roll.Length; i += 1)
            {
                Console.WriteLine(roll[i]);
            }

            foreach(int num in roll)
            {
                Console.WriteLine(num);
            }

            int[] myArray = new int[2];
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }


        }
    }
}

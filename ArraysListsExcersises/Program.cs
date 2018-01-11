using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsExcersises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex1
            var names = new List<string>();
            int length = names.Count;

            while (true)
            {
                Console.WriteLine("Enter user name.");
                var input = Console.ReadLine();

                if (input == "")
                    break;
                names.Add(input);
            }

            Console.WriteLine("List:");
            foreach (string x in names)
                Console.WriteLine(x);

            Console.WriteLine("");
            Console.WriteLine("List length: " + length);
            Console.WriteLine("");

            switch (length)
            {
                case 0:
                    Console.WriteLine("No one likes you");
                    break;
                case 1:
                    Console.WriteLine(names[0] + " likes you");
                    break;
            }


        }
    }
}

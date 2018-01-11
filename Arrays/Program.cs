using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] {3,7,9,2,14,6 };
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
            //Length
            Console.WriteLine("Lenght: " + numbers.Length);


            //IndexOf() - w jakim miejscu znajduje się dany znak
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear() - wyczyszczenie tablicy i zastąpienie elemntów wartościami domyślnymi
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("\nEffect of Clear()");

            foreach (int x in numbers)
                Console.WriteLine(x);

            //Copy()
            int[] another = new int[3]; //nowa tablica 3-elementowa

            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");

            foreach (int x in another)
                Console.WriteLine(x);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (int x in numbers)
                Console.WriteLine(x);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (int x in numbers)
                Console.WriteLine(x);
        }
    }
}

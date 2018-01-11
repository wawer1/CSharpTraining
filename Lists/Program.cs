using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4}; //deklaracja listy z wartościami
            numbers.Add(1); //dodanie elementu do listy
            numbers.AddRange(new int[3] { 5, 6, 7 }); //dodanie tablicy do listy

            foreach (int num in numbers)
                Console.WriteLine(num);

            Console.WriteLine();

            //IndexOf()
            var pos = numbers.IndexOf(1); //1. wystąpienie wartości
            Console.WriteLine(pos);
            var pos2 = numbers.LastIndexOf(1); //ostatnie wystąpienie wartości
            Console.WriteLine(pos2);

            Console.WriteLine();

            //Count - długość listy
            Console.WriteLine("Count: " + numbers.Count);


            //Remove //usunięcie pierwszego wystąpienia danej wartości
            //numbers.Remove(1);

            /*foreach (int num in numbers)  // NIE WOLNO UŻYWAC FOREACH DO USUWANIA EL. Z LISTY
            {
                if(num ==1)
                numbers.Remove(num);

            }*/

            Console.WriteLine();

            for (var i =0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (int num in numbers)
                Console.WriteLine(num);

            //Clear - usuwa wszystkie elementy z listy
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);


        }
    }
}

using System;
using System.Collections.Generic;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int n = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++) {
                list.Add(Int32.Parse(Console.ReadLine()));
            }
            showList(list);
            list.Sort();
            showList(list);

            int newElem = Int32.Parse(Console.ReadLine());
            list.Add(newElem);
            list.Sort();
            Console.WriteLine("index: " + list.BinarySearch(newElem));
            showList(list);
        }

        public static void showList(List<int> l) {
            for (int i = 0; i < l.Count; i++) {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

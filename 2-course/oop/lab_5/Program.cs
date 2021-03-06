﻿using System;
using System.Collections.Generic;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("Input n: ");
            int n = Int32.Parse(Console.ReadLine());
            
            Console.Write("Input n numbers: ");
            for (int i = 0; i < n; i++) {
                list.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.Write("Unordered list: ");
            showList(list);
            list.Sort();
            Console.Write("Ordered list: ");
            showList(list);
            Console.Write("Input new element: ");
            int newElem = Int32.Parse(Console.ReadLine());
            list.Add(newElem);
            list.Sort();
            Console.WriteLine("index: " + list.BinarySearch(newElem));
            Console.Write("Ordered list: ");
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

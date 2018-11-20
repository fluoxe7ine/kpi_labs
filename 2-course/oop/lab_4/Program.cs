using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort<int> sort = new Sort<int>(3,2,1,4);
            Sort<string> sort2 = new Sort<string>("3", "12", "15", "92");
            Date d1 = new Date("02.11.21");
            Date d2 = new Date("03.08.12");
            Date d3 = new Date("02.11.16");
            Date d4 = new Date("01.11.21");
            Time t1 = new Time("14:48");
            Time t2 = new Time("12:54");
            Time t3 = new Time("10:44");
            Time t4 = new Time("10:44");
            Sort<Date> sort3 = new Sort<Date>(d1, d2, d3, d4);
            Sort<Time> sort4 = new Sort<Time>(t1, t2, t3, t4);
            sort3.sortArray();
            Console.Write("Відсортовані дати: ");
            for (int i = 0; i < sort.data.Length; i++) {
                Console.Write(sort3.data[i].day + "/" + sort3.data[i].month + "/" + sort3.data[i].year + " ");
            }
            Console.WriteLine();
            
            sort4.sortArray();
            Console.Write("Відсортований час: ");
            for (int i = 0; i < sort.data.Length; i++) {
                Console.Write(sort4.data[i].hours + ":" + sort4.data[i].minutes + " ");
            }
            Console.WriteLine();
            sort.sortArray();
            Console.Write("Відсортовані числа: ");
            sort.showArray();
            sort2.sortArray();
            Console.Write("Відсортовані рядки: ");
            sort2.showArray();
        }
    }
}

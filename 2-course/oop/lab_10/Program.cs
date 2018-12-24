using System;
using System.Collections;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Alexander", "Kozyriev", "15.05.2000", Education.Master, "ip71", 218218);
            Console.WriteLine(s);
            try {
                s.id = 9999;
            }
            catch (IdException e) {
                Console.WriteLine(e.Message);
            }
            s.AddExams(new Examination(), new Examination(), new Examination(2, "Physics", "Linchevskiy I.V.", 90, "diff", "21.05.2000"), new Examination(4, "Physics", "Linchevskiy I.V.", 100, "diff", "21.05.2000"));
            s.PrintFullInfo();

            Console.WriteLine();
            foreach (Examination ex in s.GetEnumerator(80))
            {
                Console.WriteLine(ex);
            }

            Examination[] sorted = s.SortExams();

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace lab_4
{
    class Sort<T> where T : IComparable<T>
    {
        public T[] data = new T[4];

        public Sort(T t1, T t2, T t3, T t4){
            data[0] = t1;
            data[1] = t2;
            data[2] = t3;
            data[3] = t4;
        }

        public void showArray() {
            for (int i = 0; i < data.Length; i++) {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }


         public void sortArray(){
            int j;
            for (int i = 1; i < data.Length; i++) {
                j = i;
                while ((j > 0) && (data[j].CompareTo(data[j - 1])< 0)) {
                    T temp = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = temp;
                    j--;
                }
            }
        }
    }
}


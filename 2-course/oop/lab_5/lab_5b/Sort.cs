using System;
using System.Collections.Generic;

namespace lab_4
{
    class Sort<T> where T : IComparable<T>
    {
        // public T[] data = new T[4];
        public List<T> data; 
        public Sort(params T[] elems){
            this.data = new List<T>(elems);
        }

        public void showArray() {
            for (int i = 0; i < data.Count; i++) {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }


         public void sortArray(){
            for (int i = 0; i < data.Count - 1; i++) {
                for (int j = i + 1; j > 0; j--) {
                    if(data[j].CompareTo(data[j - 1]) < 0) {
                        T temp = data[j-1];
                        data[j-1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
}


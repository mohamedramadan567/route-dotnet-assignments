using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Sorter<T> where T : IComparable<T>
    {
        public void BubbleSort(T[] array)
        {
            for(int i = 0;  i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        public T FindMax(T[] array)
        {
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i].CompareTo(max) > 0)
                    max = array[i];
            }
            return max;
        }
    }
}

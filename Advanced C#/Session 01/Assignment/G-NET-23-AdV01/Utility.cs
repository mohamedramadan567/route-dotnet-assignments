using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Utility
    {
        public static void Swap<T>(ref T number1, ref T number2)
        {
            T temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public static T FindMax<T>(T[] items) where T : IComparable<T> 
        {
            T max = items[0];
            for(int i = 1; i < items.Length; i++)
            {
                //if (items[i] > max)
                if (items[i].CompareTo(max) > 0)
                        max = items[i];
            }
            return max;
        }
    }
}

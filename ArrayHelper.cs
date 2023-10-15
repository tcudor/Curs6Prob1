using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6Prob1
{
    internal class ArrayHelper
    {
        public static int MinR(int[] array, int start, int end)
        {
            if (start == end)
            {
                return array[start];
            }

            int middle = (start + end) / 2;
            int leftMin = MinR(array, start, middle);
            int rightMin = MinR(array, middle + 1, end);

            return leftMin < rightMin ? leftMin : rightMin;
        }

        public static int MaxR(int[] array, int start, int end)
        {
            if (start == end)
            {
                return array[start];
            }

            int middle = (start + end) / 2;
            int leftMax = MaxR(array, start, middle);
            int rightMax = MaxR(array, middle + 1, end);

            return leftMax > rightMax ? leftMax : rightMax;
        }
    }
}

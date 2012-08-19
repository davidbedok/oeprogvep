using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorts
{
    enum SortOrder {
        Up = 0,
        Down = 1
    }

    class MySort
    {
        public static SortOrder sortOrder;

        public int[] FArray;

        public MySort(int[] pArray)
        {
            FArray = pArray;
        }

        private void Swap(int a, int b)
        {
            int temp;
            temp = FArray[a];
            FArray[a] = FArray[b];
            FArray[b] = temp;
        }

        public int BubbleSort()
        {
            int num = 0;
            for (int i = 0; i < FArray.Length; i++)
            {
                for (int j = i; j < FArray.Length; j++)
                {
                    switch (MySort.sortOrder)
                    {
                        case SortOrder.Up:
                            if (FArray[i] > FArray[j])
                            {
                                Swap(i, j);
                                num++;
                            }
                            break;
                        case SortOrder.Down:
                            if (FArray[i] < FArray[j])
                            {
                                Swap(i, j);
                                num++;
                            }
                            break;
                    }
                }

            }
            return num;
        }

        public int MinMaxExcretorySort()
        {
            int num = 0;
            int min_max;
            int min_max_pos;
            int g = 0;
            for (int i = 0; i < (FArray.Length - 1); i++)
            {
                min_max = FArray[i];
                min_max_pos = i;
                for (int j = (i + 1); j < FArray.Length; j++)
                {
                    switch (MySort.sortOrder)
                    {
                        case SortOrder.Up:
                            if (FArray[j] < min_max)
                            {
                                min_max = FArray[j];
                                min_max_pos = j;
                            }
                            break;
                        case SortOrder.Down:
                            if (FArray[j] > min_max)
                            {
                                min_max = FArray[j];
                                min_max_pos = j;
                            }
                            break;
                    }
                }
                Swap(i, min_max_pos);
                num++;
            }
            return num;
        }



    }
}

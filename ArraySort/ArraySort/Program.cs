using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 11, 11, 35, 71, 39, 13, 6, 53, 43, 43 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //bubblesort(array);
            //gnomesort(array);
            //mergesort(array);
            //countingsort(array);
            //bucketsort(array);
            //combsort(array);
            //beadsort(array);
            //selectionsort(array);
            //pancakesort(array);
            //stoogesort(array);
            //shakersort(array);
            //radixsort(array);
            //hoaresort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Read();

        }

        private static void bubblesort(int[] array)
        {
            bool doit = true;
            int u = 0;
            while (doit)
            {

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int x = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = x;
                    }
                    else
                    {
                        u++;
                    }
                }
                if (u == array.Length - 1)
                {
                    doit = false;
                }
                u = 0;
            }

        }
        private static void gnomesort(int[] array)
        {
            int j = 2;
            int i = 1;

            while (i < array.Length)
            {
                if (array[i - 1] < array[i])
                {
                    i = j;
                    j = j + 1;
                }
                else
                {
                    int u = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = u;
                    i = i - 1;
                    if (i == 0)
                    {
                        i = j;
                        j = j + 1;
                    }
                }
            }

        }
        private static void mergesort(int[] array)
        {
            int[] x = new int[array.Length / 2];
            int[] y = new int[array.Length - x.Length];

            for (int i = 0; i < array.Length / 2; i++)
            {
                x[i] = array[i];
            }
            int j = array.Length / 2;
            for (int i = j; i < array.Length; i++)
            {
                y[i - array.Length / 2] = array[i];
            }

            if (x.Length != 1)
            {
                mergesort(x);
            }
            if (y.Length != 1)
            {
                mergesort(y);
            }
            
            int leng = x.Length + y.Length;
            int ix = 0;
            int iy = 0;
            int k = 0;
            while (leng != 0)
            {
                if (x[ix] < y[iy])
                {
                    array[k] = x[ix];
                    leng--;
                    k++;
                    ix++;
                }
                else
                {
                    array[k] = y[iy];
                    leng--;
                    k++;
                    iy++;
                }
                if (ix == x.Length)
                {
                    for (int o = iy; o < y.Length; o++)
                    {
                        array[k] = y[o];
                        k++;
                    }
                    leng = 0;
                }
                if (iy == y.Length)
                {
                    for (int o = ix; o < x.Length; o++)
                    {
                        array[k] = x[o];
                        k++;
                    }
                    leng = 0;
                }
            }
        }
        private static void countingsort(int[] array)
        {
            int[] C = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                C[i] = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                C[array[i]] = C[array[i]] + 1;
            }

            int b = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < C[i]; j++)
                {
                    array[b] = i;
                    b++;
                }
            }
        }
        private static void bucketsort(int[] array)
        {
            List<int[]> bucket = new List<int[]>();
            for (int i = 0; i < 10; i++)
            {
                int[] a = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
                bucket.Add(a);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length + 1; j++)
                {
                    int n = 0;
                    if ((array[i] < j * 10) && (j * 10 - 10 <= array[i]))
                    {
                        while (bucket[j - 1][n] != -1)
                        {
                            n++;
                        }
                        bucket[j - 1][n] = array[i];
                    }
                    n = 0;
                }
            }

            foreach (var p in bucket)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    for (int i = 0; i < p.Length - 1; i++)
                    {
                        if (p[i] > p[i + 1])
                        {
                            int x = p[i];
                            p[i] = p[i + 1];
                            p[i + 1] = x;
                            x = 0;
                        }
                    }
                }
            }

            int u = 0;
            foreach (var p in bucket)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] != -1)
                    {
                        array[u] = p[i];
                        u++;
                    }
                }
            }
        }
        private static void combsort(int[] array)
        { 
        double d = 1.247899999;
        bool doit = true;
        int teeth = Convert.ToInt16(array.Length / d);
        int u = 0;
            while (doit)
            {

                for (int i = 0; i < array.Length - teeth; i++)
                {
                    if (array[i] > array[i + teeth])
                    {
                        int x = array[i];
                        array[i] = array[i + teeth];
                        array[i + teeth] = x;
                    }
                    else
                    {
                        u++;
                    }
                }
                if (u == array.Length - 1)
                {
                    doit = false;
                }
                u = 0;
                if (teeth == 2)
                {
                    teeth = 1;
                }
                teeth = Convert.ToInt16(teeth / d);
            }
        }
        private static void beadsort(int[] array)
        {
            int[,] field = new int[array.Length, 100];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    field[i, j] = 1;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                for (int j = array.Length - 2; j >= 0; j--)
                {
                    int o = j;
                    while ((o != 9) && (field[o, i] == 1) && (field[o + 1, i] != 1))
                    {
                        field[o, i] = 0;
                        field[o + 1, i] = 1;
                        o++;

                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
                int j = 0;
                while (field[i, j] != 0)
                {
                    array[i]++;
                    j++;
                }
            }
        }
        private static void selectionsort(int[] array)
        {
            int j = 0;
            int g = 0;
            int max = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (j = g; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        int u = max;
                        max = array[j];
                        array[j] = u;
                    }
                }
                array[i] = max;
                max = 0;
                g++;
            }
            Array.Reverse(array);
        }
        private static void pancakesort(int[] array)
        {
            for (int i = array.Count() - 1; i >= 0; --i)
            {
                int pos = i;

                for (int j = 0; j < i - 1; j++)
                {
                    if (array[j].CompareTo(array[pos]) > 0)
                    {
                        pos = j;
                    }
                }

                if (pos == i)
                {
                    continue;
                }

                if (pos != 0)
                {
                    flip(array, pos + 1);
                }

                flip(array, i + 1);
            }

            void flip(int[] arr, int i)
            {
                for (int y = 0; y < i; y++)
                {
                    --i;
                    int p = arr[y];
                    arr[y] = arr[i];
                    arr[i] = p;
                }
            }
        }
        private static void stoogesort(int[] array)
        {

            int l = 0;
            int o = array.Length-1;
            stoogesort(array, l, o);
            void stoogesort(int[] q, int i, int j)
            {
                if (q[j] < q[i])
                {
                    int u = q[j];
                    q[j] = q[i];
                    q[i] = u;
                }
                if (j - i > 1)
                {
                    int t = (j - i + 1) / 3;
                    stoogesort(q, i, j - t);
                    stoogesort(q, i + t, j);
                    stoogesort(q, i, j - t);
                }
            }
        }
        private static void shakersort(int[] array)
        {
            int left = 0,
                right = array.Length - 1,
                count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                        Swap(array, i - 1, i);
                }
                left++;
            }
            void Swap(int[] a, int i, int j)
            {
                int glass = a[i];
                a[i] = a[j];
                a[j] = glass;
            }
        }
        private static void radixsort(int[] array)
        {
            for (int j = 1; j < 3; j++)
            {
                sort(array, j);
            }
            void sort(int[] arra, int j)
            {
                List<int[]> a = new List<int[]>();
                for (int i = 0; i < 10; i++)
                {
                    int[] at = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
                    a.Add(at);
                }
                for (int i = 0; i < arra.Length; i++)
                {
                    int d = Convert.ToInt32(Math.Truncate(arra[i] / Math.Pow(10, 2 - 1) % 10));
                    int n = 0;
                    while (a[d][n] != -1)
                    {
                        n++;
                    }
                    a[d][n] = arra[i];
                }
                combine(a, arra);
                foreach (var p in a)
                {
                    for (int i = 0; i < a[0].Length; i++)
                    {
                        p[i] = -1;
                    }
                }
            }
            void combine(List<int[]> a, int[] arra)
            {
                int h = 0;
                for (int i = 0; i < arra.Length; i++)
                {
                    int g = 0;
                    while (a[i][g] != -1)
                    {
                        arra[h] = a[i][g];
                        g++;
                        h++;
                    }
                }
            }

        }
        private static void hoaresort(int[] array)
        {
            hoaresort(array, 0, array.Length - 1);
            void hoaresort(int[] q, int start, int end)
            {
                if (end == start) return;
                var pivot = q[end];
                var storeIndex = start;
                for (int i = start; i <= end - 1; i++)
                    if (q[i] <= pivot)
                    {
                        var t = q[i];
                        q[i] = q[storeIndex];
                        q[storeIndex] = t;
                        storeIndex++;
                    }

                var n = q[storeIndex];
                q[storeIndex] = q[end];
                q[end] = n;
                if (storeIndex > start) hoaresort(q, start, storeIndex - 1);
                if (storeIndex < end) hoaresort(q, storeIndex + 1, end);

            }
        }

    }
   
}

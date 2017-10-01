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

            //bubblesort(array);// console app bubblesort
            //gnomesort(array);//console app 2
            //mergesort(array);//console app 3
            //countingsort(array);//console app 4
            //bucketsort(array);//console app 5
            //combsort(array);//console app 6
            //beadsort(array);//console app 7
            //selectionsort(array);//console app 1

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
    }
}

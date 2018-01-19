using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class QuickSort
    {
        public static int[] Sort(int[] tmplst)
        {
            int pivotindex = tmplst.Length / 2 - 1;
            int leftindex = 0;
            int rightindex = tmplst.Length - 1;

            if (tmplst[leftindex] > tmplst[pivotindex])
                Swap(ref tmplst, leftindex, pivotindex);
            if (tmplst[leftindex] > tmplst[rightindex])
                Swap(ref tmplst, leftindex, rightindex);
            if (tmplst[pivotindex] > tmplst[rightindex])
                Swap(ref tmplst, pivotindex, rightindex);

            foreach (int tmp in tmplst)
                Console.Write(tmp + " ");
            Console.WriteLine();

            int sortright = tmplst.Length - 1;
            int sortleft = 0;
            while (sortleft < pivotindex)
            {
                if (tmplst[sortleft] > tmplst[pivotindex])
                {
                    while (sortright > pivotindex)
                    {
                        if (tmplst[sortright] < tmplst[pivotindex])
                        {
                            Swap(ref tmplst, sortleft, sortright);
                            sortright--;
                            break;
                        }

                        sortright--;
                    }
                }
                sortleft++;
            }

            return tmplst;
        }

        private static void Swap(ref int[] tmplst, int a, int b)
        {
            int tmpdata = tmplst[a];
            tmplst[a] = tmplst[b];
            tmplst[b] = tmpdata;
            Console.WriteLine("Swap a : {0} , b : {1} --> Data(a) : {2} Data(b) : {3}", a, b, tmplst[a], tmplst[b]);
        }
    }
}

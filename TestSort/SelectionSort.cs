using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class SelectionSort
    {
        public static int[] Sort(int[] tmplst)
        {
            int count = tmplst.Length;
            for (int i = 0; i < count; i++)
            {
                //Find min
                int minindex = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (tmplst[j] < tmplst[minindex])
                    {
                        minindex = j;
                    }
                }
                // Swap
                if (minindex != i)
                {
                    int tmp = tmplst[i];
                    tmplst[i] = tmplst[minindex];
                    tmplst[minindex] = tmp;
                }
            }


            return tmplst;
        }

        private void FindIndexMin(List<int> tmplst)
        { }
    }
}

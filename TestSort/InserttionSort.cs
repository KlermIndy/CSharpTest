using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class InserttionSort
    {
        public static int[] Sort(int[] tmplst)
        {
            int count = tmplst.Length;
            for (int i = 1; i < count; i++)
            {
                int insertindex = i;
                for (int j = i -1; j >= 0; j--)
                {
                    if (tmplst[j] > tmplst[insertindex])
                    {
                        // Swap
                        int tmp = tmplst[j];
                        tmplst[j] = tmplst[insertindex];
                        tmplst[insertindex] = tmp;

                        insertindex = j;
                    }
                }
            }

            return tmplst;
        }
    }
}

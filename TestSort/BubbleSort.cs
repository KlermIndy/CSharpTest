using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class BubbleSort
    {
        public static int[] Sort(int[] tmplst)
        {
            int count = tmplst.Length;
            for (int i = 0; i < count - 1; i++)
            {
                int bubbletindex = count - 1;
                for (int j = count - 2; j >= i; j--)
                {
                    if (tmplst[j] > tmplst[bubbletindex])
                    {
                        // Swap
                        int tmp = tmplst[j];
                        tmplst[j] = tmplst[bubbletindex];
                        tmplst[bubbletindex] = tmp;

                        // Change index
                        bubbletindex = j;
                    }
                }
            }

            return tmplst;
        }
    }
}

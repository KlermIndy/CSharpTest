using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> tmplst = new List<int>();
            int numcount = 10;
            int[] tmplst = new int[numcount];
            while (true)
            {
                for (int i = 0; i < numcount; i++)
                {
                    Console.Write("Input {0} : ",i.ToString());
                    tmplst[i] = int.Parse(Console.ReadLine());
                }

                int[] tmplst1 = SelectionSort.Sort(tmplst);
                Console.Write("Result : ");
                foreach (int tmp in tmplst1)
                    Console.Write(tmp + " ");
                Console.WriteLine();
            }
        }
    }
}

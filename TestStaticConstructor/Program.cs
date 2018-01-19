using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStaticConstructor
{
    class Program
    {
        private static int tmp = 5;
        private const int tmp1 = 10;
        static void Main(string[] args)
        {
            Console.WriteLine(tmp.ToString());
            tmp = 100;
            Console.WriteLine(tmp.ToString());
            Console.ReadLine();
        }
        //private void test()
        //{
        //    tmp1 = 100;
        //}
    }
}

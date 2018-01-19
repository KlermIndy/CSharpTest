using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAsyn
{
    class Program
    {
        delegate T Test<in T1, in T2, out T>(T1 tmp1, T2 tmp2);
        //delegate T Test1<T,T>(T tmp1, T tmp2);
        static void Main()
        {
            while (true)
            {
                // Start computation.
                Example();
                // Handle user input.
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }
        static async void Example()
        {
            //await Task.Run(() => TestAsyn());
            await Task.Run(() => TestAsyn1());
            Func<int> tmp = () => 2;
            Func<int, int> tmp1 = x => x + 2;
            Func<int, int, int> tmp2 = (x, y) => x * y;
            //Test<int, int, string> tmp3 = (x, y) => "";
            //Console.WriteLine(tmp);
        }
        static void TestAsyn()
        {
            while (true)
            {
                Console.WriteLine("TestAsyn");
                Thread.Sleep(3000);
            }
        }

        static string TestAsyn1()
        {
            return "TestAsyn1";
        }
        static int TestAsyn2()
        {
            return 2;
        }
    }

}

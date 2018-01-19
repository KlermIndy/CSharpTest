using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass.delegateClassHandle = PrintMain;
            DelegateClass.delegateClassEventHandle += new DelegateClass.DelegateClassHandle(PrintEventMain);

            DelegateClass.PrintTest("Call print Delegate from Main.");

            Console.WriteLine("----End----");
            Console.ReadLine();
        }
        private static void PrintMain(string str)
        {
            Console.WriteLine(str);
        }
        private static void PrintEventMain(string str)
        {
            Console.WriteLine(str);
        }
    }
}

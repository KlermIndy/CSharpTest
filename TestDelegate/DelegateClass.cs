using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class DelegateClass
    {
        public delegate void DelegateClassHandle(string str);
        public static DelegateClassHandle delegateClassHandle;
        public static event DelegateClassHandle delegateClassEventHandle;

        public static void PrintTest(string str)
        {
            Console.WriteLine(str);
            PrinMain("Call print Main from Delegate.");
            PrintEventMain("Call event print Main from Delegate.");
        }
        private static void PrinMain(string str)
        {
            if (delegateClassHandle != null)
                delegateClassHandle(str);
            else
                Console.WriteLine("Error");
        }

        private static void PrintEventMain(string str)
        {
            if (delegateClassEventHandle != null)
                delegateClassEventHandle(str);
            else
                Console.WriteLine("Error");
        }
    }
}

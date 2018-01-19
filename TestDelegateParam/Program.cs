using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateParam
{
    class Program
    {
        delegate void Del();
        delegate void Del2(int param);
        delegate TResult DelegateTest<in T,out TResult>(T obj);
        static void Main(string[] args)
        {
            CustomCollection<int> customcollection = new CustomCollection<int>();
            customcollection.Add(5);
            customcollection.Add(6);
            customcollection.Add(7);
            Console.WriteLine(customcollection.FindIndexDelegate(x => x == 7));
            Console.WriteLine(customcollection.Match(x => x == 7));
            Console.ReadLine();
        }
    }

    class CustomCollection<T>
    {
        public delegate TResult DelegateTest<in TInput, out TResult>(TInput obj);
        private List<T> list;
        public CustomCollection()
        {
            list = new List<T>();
        }
        public void Add(T param)
        {
            list.Add(param);
        }

        public int FindIndexDelegate(DelegateTest<T, bool> predicateTest)
        {
            int index = 0;
            foreach (T tmp in list)
            {
                if (predicateTest(tmp))
                    return index;
                index++;
            }
            return index;
        }
        public bool Match(DelegateTest<T, bool> predicateTest)
        {
            foreach (T tmp in list)
            {
                if (predicateTest(tmp))
                    return true;
            }
            return false;
        }
    }
}

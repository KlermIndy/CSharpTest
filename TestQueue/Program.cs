using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<TmpObj> tmpstack = new Stack<TmpObj>();
                Queue<TmpObj> tmpqueue = new Queue<TmpObj>();
                tmpqueue.Enqueue(new TmpObj("TestQueue1"));
                tmpqueue.Enqueue(new TmpObj("TestQueue2"));
                tmpqueue.Enqueue(new TmpObj("TestQueue3"));
                tmpstack.Push(new TmpObj("TestStack1"));
                Console.WriteLine("Count " + tmpqueue.Count);

                while (true)
                {
                    if (tmpqueue.Count > 0)
                    {
                        TmpObj strtmp = tmpqueue.Dequeue();
                        Console.WriteLine("Dequeue Queue : " + strtmp.tmpstr);
                    }
                    else
                        break;
                }

                Console.WriteLine("End");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message + Environment.NewLine + ex.StackTrace);
                Console.ReadLine();
            }

        }
    }
    class TmpObj
    {
        public TmpObj()
        { }

        public string tmpstr;
        public TmpObj(string strtmp)
        {
            tmpstr = strtmp;
        }
    }
}

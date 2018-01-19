using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    // Covariant interface.
    interface ICovariant<out T> { }

    // Implementing covariant interface.
    class Sample<R> : ICovariant<R> { }

    class Program
    {
        static void Main(string[] args)
        {
            MainTest.Test();
            Console.ReadLine();
        }
        static void Test()
        {
            ICovariant<Object> iobj = new Sample<Object>();
            ICovariant<String> istr = new Sample<String>();
            ICovariant<Array> iarray = new Sample<Array>();
            ICovariant<Char> ichar = new Sample<Char>();

            // You can assign istr to iobj because
            // the ICovariant interface is covariant.
            iobj = iarray;
        }
        static int Test1(out int tmp)
        {
            tmp = 0;
            return tmp;
        }
    }

    public class Parent { public Parent() { Console.WriteLine("CallParent"); } public string ParentTest() { Console.WriteLine("Parent CallTest"); return "Parent CallTest Return"; } }
    public class Child : Parent { public Child() { Console.WriteLine("CallChild"); } public void ChildTest() { Console.WriteLine("Child CallTest"); } }

    class Test1<TTest1> : ITest1<TTest1>
    {
        public Test1()
        {
            //ITest1 tmp = new 
            Console.WriteLine("CallTest");
        }
    }
    class Test2<TTest2> : ITest2<TTest2>
    {
        public Test2() { Console.WriteLine("CallTest"); }
        public void CallTest(TTest2 param)
        {
            Console.WriteLine("CallTest " + (param as Parent).ParentTest());
        }
    }

    interface ITest1<out T1> { }; // Can Polymophism
    interface ITest2<in T2> { void CallTest(T2 param); };  // Can't Polymophism But Can use param

    delegate void Testdelegate<in TDelegate>(TDelegate param); // in => type parameter
    delegate TDelegate Testdelegate1<out TDelegate>(); // out => type return
    delegate TDelegate Testdelegate2<TDelegate>(TDelegate param); // not have in, out => use both parameter and return
    

    class MainTest
    {
        public static void Test()
        {
            ITest1<Parent> ichild = new Test1<Child>();   // Polymophism(out in generic)
            ITest1<Parent> iparent = ichild;

            ITest2<Parent> ichild2 = new Test2<Parent>(); // ITest2<Parent> ichild2 = new Test2<Child>(); Error => Can't to Polymophism(in in generic)
            ichild2.CallTest(new Parent());

            //Parent parent = new Parent();
            //Child child = new Child();
            //Parent tmp = child;

            //IEnumerable<Parent> fruit = new List<Child>();
            //ITest1<Parent> iparent1 = new Test<Child>();
            ////ITest2<Parent> iparent2 = new Test<Child>(); Can't

            //// TestDelegate
            //Testdelegate<Parent> testdelegate = x => new Test<Child>();
            //testdelegate(new Child());

            //Testdelegate1<Parent> testdelegate1 = () => new Child();
            //testdelegate1();

            //Testdelegate2<int> testdelegate = x => x + 10;
            //List<string> tmp = new List<string>();
            //tmp.Add("10");
            //tmp.Add("100");
            //tmp.ConvertAll<int>(new Converter<string, int>(x => 5));
            //Console.WriteLine(testdelegate(5));

        }
    }
}

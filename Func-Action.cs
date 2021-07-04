using System;

namespace ActionFunc
{
    class Program
    {
        public delegate void calc01();
        public delegate void calc02(int a, int b);
        public delegate int calc03();
        public delegate int calc04(int a, int b);

        //public static void testCalc01() { }
        //public static void testCalc02(int a , int b) { }
        //public static int testCalc03() {
        //    return 1;
        //}

        //public static int testCalc04(int a , int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            // calc01 c01 = () => { Console.WriteLine("I am c01"); };
            // calc02 c02 = (a, b) => { Console.WriteLine("I am c02"); };
            // calc03 c03 = () => 1;
            // calc04 c04 = (a, b) => a + b;
            // c01();
            // c02(1,2);
            //Console.WriteLine(c03());
            //Console.WriteLine(c04(1,2));
            Action c01 = () => { Console.WriteLine("I am c01"); };
            Action<int,int> c02 = (a, b) => { Console.WriteLine("I am c02"); };
            Func<int> c03 = () => 1;
            Func <int,int,int> c04= (a, b) => a + b;
            c01();
            c02(1, 2);
            Console.WriteLine(c03());
            Console.WriteLine(c04(1, 2));

            // the last parameter in func represent return type
            //Action when we dont have return type
            //Function when we have return type


        }
    }
}

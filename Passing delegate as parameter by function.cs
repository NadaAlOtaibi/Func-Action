using System;

namespace ActionFunc
{
    class Program
    {

        static void Main(string[] args)
        {
            Test t = new Test();
            t.passingDel(1, 2, (x, y) => x * y);


        }
    }
    class Test
    {
        //Passing delegate as parameter by function 
        public void passingDel(int a , int b , Func<int , int , int > op)
        {
            int result = op(a, b);
            Console.WriteLine(result);
        }

    }
}

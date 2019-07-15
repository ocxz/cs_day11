using System;

namespace _06_ToString的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  将对象打印输出到控制台，默认是打印对象的全部限定名
             *  如：Console.WriteLine(new int[3] {1,2,3} )
             *  结果是：System.Int32[]
             *  如：Console.WriteLine(new Person());
             *  结果是：_06_ToString的问题.Person
             * 
             */

            Console.WriteLine(new int[3] { 1, 2, 3 });
            Console.ReadKey();
            Console.WriteLine(new Person());
            Console.ReadKey();
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}

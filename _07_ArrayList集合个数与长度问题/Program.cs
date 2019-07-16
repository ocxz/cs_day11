using System;
using System.Collections;

namespace _07_ArrayList集合个数与长度问题
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.WriteLine("列表的元素个数为：{0}", list.Count);
                Console.WriteLine("列表的长度为{0}", list.Capacity);
                Console.ReadKey();
            }
        }
    }
}

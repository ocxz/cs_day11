using System;
using System.Collections;

namespace _05_ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  集合简介：很多数据的一个集合 类型不一定都相同
             *  命名空间引用：using System.Collections;
             *  创建集合：ArrayList list = new ArrayList();
             *  数组的缺陷：长度不可变，只能存储单一类型元素 
             *  集合优点：长度可以任意改变，而类型随意
             * 
             */


            #region list中添加数据之Add添加 局限性：拿出来的时候需要进行类型转换，以及ToString问题
            //        ArrayList list = new ArrayList();
            //        list.Add(1);
            //        list.Add(3.14);
            //        list.Add(true);
            //        list.Add("张三");
            //        list.Add('男');
            //        list.Add(500m);
            //        list.Add(new int[] { 1, 2, 3, 4, 5 });
            //        list.Add(new Person());
            //        list.Add(list);

            //        for (int i = 0; i < list.Count; i++)
            //        {
            //            if (list[i] is Person)
            //            {
            //                ((Person)list[i]).SayHello();
            //            }
            //            else if (list[i] is int[])
            //            {
            //                for (int j = 0; j < ((int[])list[i]).Length; j++)
            //                {
            //                    Console.Write("{0} ", ((int[])list[i])[j]);
            //                }
            //                Console.WriteLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine(list[i]);
            //            }
            //        }

            //        Console.ReadKey();
            //    }
            #endregion

            #region list添加数据之AddRange添加(使用于数组、对象添加到list中）

            ArrayList list = new ArrayList();

            //添加单个元素
            list.Add(true);
            list.Add(1);
            list.Add("张三");

            // 添加数组、或者对象 用AddRange添加
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            // AddRange 添加list(自己也可以哦）
            list.AddRange(list);

            //list.Clear();   // 清空所有元素
            //list.Remove(true);   // 删除指定元素
            //list.RemoveAt(1);      // 根据索引指定删除
            list.RemoveRange(0, 3);   // 根据前后索引，指定删除多个元素  左闭右闭
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            #endregion
        }
        public class Person
        {
            public void SayHello()
            {
                Console.WriteLine("我是人类");
            }
        }
    }
}

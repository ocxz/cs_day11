using System;
using System.Collections;

namespace _09_Hashtable键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Hashtable 键值对集合对象
            Hashtable hashtable = new Hashtable();

            // 通过key-value添加元素
            hashtable.Add(1, "张三");
            hashtable.Add(2, true);
            hashtable.Add(3, '男');
            hashtable.Add(true, "正确");
            hashtable.Add(false, "错误");

            #region 循环取出 hashtable.Count 获取集合中键值对元素的数量
            ////循环取出 hashtable.Count 获取集合中键值对元素的数量
            //for (int i = 0; i < hashtable.Count; i++)
            //{
            //    Console.Write(hashtable[]);
            //Console.ReadKey();
            //}
            #endregion

            #region Hashtable 键值对 根据key来取值的
            //// Hashtable 键值对 根据key来取值的
            //Console.WriteLine(hashtable[1]);
            //Console.WriteLine(hashtable[2]);
            //Console.WriteLine(hashtable[3]);
            //Console.WriteLine(hashtable[true]);
            //Console.WriteLine(hashtable[false]);
            //Console.ReadKey();
            #endregion

            #region foreach 逐步遍历集合对象，并取出  foreach (var item in hashtable.Keys){ hashtable[item] }

            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine("{0}---->{1}", item, hashtable[item]);     
            //}
            //Console.ReadKey();

            #endregion

            #region hashtable.Values 取出hashtable中所有的值

            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine("集合中的值为：{0}", item);
            //}


            #endregion




        }
    }
}

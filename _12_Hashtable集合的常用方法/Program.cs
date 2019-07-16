using System;
using System.Collections;

namespace _12_Hashtable集合的常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             *  1：判断包含 ht.Contains(key)、ht.ContainsKey(key)、ht.ContainsValue(value)
             *  2：清空元素 ht.Clear();
             *  3：移除元素 ht.Remove();
             */

            // 创建一个Hashtable 键值对集合对象
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(true, "正确");
            ht.Add(false, "错误");
            ht.Add("abc", "cba");

            #region ht.Contains（key） 判断是否包含该key
            //// ht.Contains(key) 判断是否包含该key
            //if (ht.Contains(1))
            //{
            //    Console.WriteLine(ht[1]);
            //} 
            #endregion

            #region ht.ContainsKey(key) 判断是否包含该key
            //// ht.ContainsKey(key) 判断是否包含该key
            //if (ht.ContainsKey("abc"))
            //{
            //    Console.WriteLine(ht["abc"]);
            //}
            //else
            //{
            //    ht.Add("abc", "cba");
            //    Console.WriteLine("原不包含，已加入{0}---->{1}", "abc", ht["abc"]);
            //} 
            #endregion

            #region ht.ContainsValue(value) 判断是否包含该值

            //if (ht.ContainsValue("正确"))
            //{
            //    Console.WriteLine("存在正确这个值");
            //}
            //else
            //{
            //    Console.WriteLine("不存在，请添加");
            //}

            #endregion



        }
    }
}

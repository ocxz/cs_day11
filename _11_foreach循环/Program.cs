using System;
using System.Diagnostics;

namespace _11_foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach循环  之for与foreach循环遍历数组简易难度之比
            //// for循环遍历数组，与foreach遍历数组之比较
            //int[] nums = { 1, 2, 3, 4, 5, 6 };

            //// for 循环遍历数组
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0} ", nums[i]);
            //}
            //Console.WriteLine("\n++++++++++++++++++++++++++++++");

            //// foreach 循环遍历数组
            //foreach (var item in nums)
            //{
            //    Console.Write("{0} ", item); 
            // }
            #endregion

            #region foreach循环  之for与foreach循环遍历数组速度之比

            //int[] nums = new int[100000000];   // 定义一个一亿元素数组

            //Stopwatch sw = new Stopwatch();   // 声明并定义一个计算器
            //sw.Start();     // 计时开始

            //// for 循环 一亿元素数组 操作一亿元素数组
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = 1;
            //}
            //sw.Stop();
            //// sw.Elapsed表示计时的时间
            //Console.WriteLine("for循环操作一亿元素数组所花费的时间：{0}", sw.Elapsed);

            //// foreach 循环操作一亿元素数组
            //sw.Start();
            //foreach (var item in nums)
            //{
                
            //}
            //sw.Stop();
            //Console.WriteLine("foreach循环操作一亿元素数组所花费的时间：{0}", sw.Elapsed); 

            #endregion
        }
    }
}

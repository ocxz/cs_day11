using System;
using System.Collections;

namespace _08_ArrayList小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  1、往集合中加几个int数，循环取出，并求最大值、最小值、平均数、总和
             *  注意点：取出的元素为Object类型，需要进行强转
             *  集合中加入的数1-1000的随机数，且不能重复
             */

            // 第一步 声明并初始化集合，循环往集合中添加int类型数
            Random r = new Random();
            while (true)
            {
                ArrayList list = new ArrayList();
                for (int i = 0; i < r.Next(10, 20); i++)  // 随机往集合中加入10-20个元素
                {
                    int rNumber = r.Next(1, 1000);    // 生成一个1-10000的随机数
                    while (list.Contains(rNumber))    // 如果集合中已经存在该数，则重新生成
                    {
                        rNumber = r.Next(1, 1000);
                    }
                    list.Add(rNumber);       // 将该数加入到集合中
                }

                // 循环取出，并进行相关操作
                int max = (int)list[0];     // 确保max、min在该集合中
                int min = (int)list[0];
                int sum = 0;

                Console.Write("集合");
                for (int i = 0; i < list.Count; i++)
                {
                    max = max > (int)list[i] ? max : (int)list[i];
                    min = min < (int)list[i] ? min : (int)list[i];
                    sum += (int)list[i];
                    Console.Write(" {0}", list[i]);
                }
                double avg = double.Parse((sum / list.Count).ToString("0.00"));
                Console.WriteLine(" 的最大值为{0}，最小值为{1}，平均值为{2}，总和为{3}", max, min, avg, sum);
                Console.ReadKey();
                Console.WriteLine(); 
            }

        }
    }
}

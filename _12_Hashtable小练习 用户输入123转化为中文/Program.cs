using System;
using System.Collections;

namespace _12_Hashtable小练习_用户输入123转化为中文
{
    class Program
    {
        private const string nums = "0123456789";
        private const string chinese = "零一二三四五六七八九";
        static void Main(string[] args)
        {
            /**
             *   用Hashtable实现
             *   将用户输入的123转化为中文一二三
             *   将用户输入的一二三转化为数字123
             */

            Hashtable numToChinese = new Hashtable();
            Hashtable chineseToNum = new Hashtable();

            // 分别将中、数作为key或value加入到Hashtable中
            for (int i = 0; i < nums.Length; i++)
            {
                numToChinese[nums[i]] = chinese[i];
                chineseToNum[chinese[i]] = nums[i];
            }

            while (true)
            {
                bool isReset = false;    // 定义一个标识符，表示是否需要continue该次循环
                Console.WriteLine("请输入一个数");
                string input = Console.ReadLine();

                #region 判断是否为空或空串

                if (string.IsNullOrEmpty(input))   // 判断是否为空或空串
                {
                    Console.WriteLine("输入不合法，请重新输入");
                    break;
                }
                else if (input == "exit" || input == "Exit")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)   // 判断输入合不合法 不合法，重新输入
                    {
                        if (!numToChinese.ContainsKey(input[i]) && !chineseToNum.ContainsKey(input[i]))
                        {
                            Console.WriteLine("输入不合法，请重新输入");
                            isReset = true;
                            break;
                        }
                    }
                }

                #endregion

                #region 判断是否需要跳过本次循环

                // 判断是否需要跳过本次循环
                if (isReset)
                {
                    continue;
                }

                #endregion

                #region 循环判断 根据第一个数来确定转换规则

                // 循环判断 根据第一个数来确定转换规则
                if (numToChinese.ContainsKey(input[0]))
                {   // 根据第一个元素判断转换规则，如果时num则numToChinese
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (numToChinese.ContainsKey(input[i]))   // 如果用户输入的是数字 则转换并输入
                        {
                            Console.Write(numToChinese[input[i]]);
                        }
                        else    // 如果用户输入的是汉字 则直接输入
                        {
                            Console.Write(input[i]);
                        }
                    }
                }
                else        // 第一个元素是中文 则按照chineseToNum规则转换
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (chineseToNum.ContainsKey(input[i]))   // 如果用户输入的是数字 则转换并输入
                        {
                            Console.Write(chineseToNum[input[i]]);
                        }
                        else    // 如果用户输入的是汉字 则直接输入
                        {
                            Console.Write(input[i]);
                        }
                    }
                } 

                #endregion

                Console.WriteLine();
            }



        }
    }
}

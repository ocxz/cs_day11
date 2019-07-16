using System;
using System.IO;
using System.Text;

namespace _17_File类的写操作
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  与文件读操作类似
             *  1、字节码写入  传入字节码数组
             *  2、所有行写入  传入字符串数组 一个写一行
             *  3、所有文本写入  传入字符串
             *  4、追加写入文本
             *  5、追加写入多行
             */

            #region 第一种 字节码方式写入

            //File.WriteAllBytes("new2.txt", Encoding.Default.GetBytes("今天真是好热啊"));
            //Console.WriteLine("写入完成");
            //Console.ReadKey();

            #endregion

            #region 第二种 所有行写入

            //string[] names = { "张三", "王五", "赵六", "张三", "田小七", "王八蛋" };
            //File.WriteAllLines("new2.txt", names,Encoding.Default);
            //Console.WriteLine("写入完成");
            //Console.ReadKey();

            #endregion

            #region 第三种 所有文本写入

            //string text = "你今天真漂亮。\n哼，难道我昨天不漂亮吗？";
            //File.WriteAllText("new2.txt", text, Encoding.Default);
            //Console.WriteLine("写入完成");
            //Console.ReadKey();

            #endregion

            #region 第四种 追加写入文本

            //String str = "\n错错错，我的错，我的小公举天天都很漂亮\n哼，这还差不多";
            //File.AppendAllText("new2.txt", str, Encoding.Default);
            //Console.WriteLine("追加写入成功");
            //Console.ReadKey();

            #endregion

            #region 第五种 追加写入多行

            //string[] strs = { "\n说你爱我", "快说你爱我", "快说嘛", "你说不说", "我生气了啊", "哼，你等着", "我错了，快说爱我", "我爱你，你快说爱我呀", "想你想到疯狂窒息" };

            //File.AppendAllLines("new2.txt", strs, Encoding.Default);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            #endregion


        }
    }
}

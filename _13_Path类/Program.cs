using System;
using System.IO;

namespace _13_Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  引入命名空间：using System.IO;
             *  Path是一个静态类，不需要实例化对象
             * 
             */

            string path = @"F:\c#代码\第十一天\第十一天解决方案\_13_Path类\Program.cs";

            //// 第一种方法，通过字符串操作 拿到文件名
            //string name = path.Substring(path.LastIndexOf("\\")+1);
            //Console.WriteLine(name);
            //Console.ReadKey();

            // 用Path.GetFileName(path);
            Console.WriteLine(Path.GetFileName(path));

            // Paht.GetFileNameWithoutExtension 获得无扩展名的文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

            // Path.GetExtension(path) 获得文件扩展名
            Console.WriteLine(Path.GetExtension(path));

            // 获得文件夹名
            Console.WriteLine(Path.GetDirectoryName(path));

            // 获得文件全路径
            Console.WriteLine(Path.GetFullPath(path));

            // 文件路径组合 连接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\a\"+"b.txt"));

        }
    }
}

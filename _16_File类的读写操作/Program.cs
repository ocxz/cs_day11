using System;
using System.IO;
using System.Text;

namespace _16_File类的读写操作
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  1、读取文件数据，用二进制数组接收
             *  将二进制转换为字符串 选用默认编码
             *  2、利用ReadAllLines(path,Encoding.Default)读取文件所有行  文本文件
             *  3、利用ReadAllText(path,Encoding.Default) 读取所有文本 返回字符串
             *  4、相对路径 文件放入：bin\Debug\netcoreapp2.1 然后直接用文件名进行读写操作
             */

            #region 一、利用ReadAllBytes(path)读取文件，利用Encoding.Default.GetString(bytes)获得字符串
            //// 1、读取文件数据，用二进制数组接收
            //byte[] buffer = File.ReadAllBytes(@"F:\c#代码\第十一天\第十一天解决方案\_16_File类的读写操作\test\new.txt");

            //// 2、将二进制转换为字符串 选用默认编码
            //string str = Encoding.Default.GetString(buffer);
            //Console.WriteLine(str);
            //Console.ReadKey(); 
            #endregion

            #region 二、利用ReadAllLines(path)读取文件所有行 返回值存于字符串数组中

            //string filePath = @"F:\c#代码\第十一天\第十一天解决方案\_16_File类的读写操作\test\new.txt";
            //string[] strs = File.ReadAllLines(filePath,Encoding.Default);

            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();


            #endregion

            #region 三、利用ReadAllText(path,Encoding.Default) 读取所有文本 返回字符串

            //string filePath = @"F:\c#代码\第十一天\第十一天解决方案\_16_File类的读写操作\test\new.txt";
            //string str = File.ReadAllText(filePath, Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            #region 四、相对路径 文件放入：bin\Debug\netcoreapp2.1 然后直接用文件名进行读写操作

            //string str = File.ReadAllText("new.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion
        }

    }
}

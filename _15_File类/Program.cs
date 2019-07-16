using System;
using System.IO;
using System.Text;

namespace _15_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\c#代码\第十一天\第十一天解决方案\_15_File类\new78.cs";
            #region File.Create(path) 创建文件

            //File.Create(path);
            //Console.WriteLine("创建成功");

            #endregion

            #region File.Create(path) 删除文件

            //File.Create(path); //删除文件

            //File.Delete(path);
            //Console.WriteLine("删除{0}文件成功", Path.GetFileNameWithoutExtension(path));
            //Console.ReadKey();

            #endregion

            #region File.Copy(源文件路径,目标文件路径）文件复制

            //string newFileName = "new98.cs";
            //File.Copy(path, Path.Combine(Path.GetDirectoryName(path) +"\\"+ newFileName));
            //Console.WriteLine("复制文件{0}到文件{1}成功",
            //    Path.GetFileName(path),newFileName);
            //Console.ReadKey();

            #endregion

            #region File.Move(源文件路径,目标文件路径） Directory.CreateDirectory(文件夹路径）
            //string dirName = "新的文件夹";
            //string dirPath = Path.Combine(Path.GetDirectoryName(path) + "\\" + dirName);
            //Directory.CreateDirectory(dirPath);
            //Console.WriteLine("文件夹{0}创建成功，点击任意键继续操作", dirName);
            //File.Move(path, dirPath + "\\" + Path.GetFileName(path));
            //Console.WriteLine("目标文件{0}迁往{1}成功"
            //    , Path.GetFileName(path), dirPath.Substring(dirPath.LastIndexOf("\\") + 1));

            //Console.ReadKey(); 
            #endregion

            #region Directory.Delete(文件夹路径） 文件夹的删除

            //string dirName = @"F:\c#代码\第十一天\第十一天解决方案\_15_File类\新的文件夹";
            //Directory.Delete(dirName);
            //Console.WriteLine("文件夹{0}删除成功", dirName.Substring(dirName.LastIndexOf("\\") + 1));
            //Console.ReadKey(); 

            #endregion

            #region File.WriteAllBytes(文件路径,Encoding.Default.GetBytes(字符串））

            //string mypath = @"F:\c#代码\第十一天\第十一天解决方案\_15_File类\新的文件夹\new.txt";

            //string iWantSay = @"今天天天气好晴朗，处处好风光！";

            //File.WriteAllBytes(mypath,Encoding.Default.GetBytes(iWantSay));
            //Console.WriteLine("写{0}到文件{1}成功", iWantSay, Path.GetFileName(mypath));
            //Console.ReadKey();

            #endregion

            #region File.WriteAllText(文件路径，写入的字符串） 写入全文本 覆盖式写入

            //string mypath = @"F:\c#代码\第十一天\第十一天解决方案\_15_File类\新的文件夹\new.txt";
            //File.WriteAllText(mypath, "难受啊，小老弟儿");
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            #endregion

            #region 文件流操作 略带

            //string mypath = @"F:\c#代码\第十一天\第十一天解决方案\_15_File类\新的文件夹\new.txt";
            //FileStream fs = File.OpenWrite(mypath);
            //String str = "问什么呀\n";
            //fs.Write(Encoding.Default.GetBytes(str));
            //fs.Close();
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            #endregion




        }
    }
}

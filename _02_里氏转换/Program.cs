using System;

namespace _02_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   object 一切子类的基类
             *   
             *   里氏转换：类似于多态
             *   子类可以赋值给父类，如果有地方需要子类做参数，我们可以传入子类代替
             *   string.Join(char separator, params object[] values) 
             *   当我们需要连接字符串时，传入的就是String类（Object类的子类）
             *   string.Join("|", "三国演义", "水浒传", "西游记", "红楼梦");
             * 
             * 
             */

            #region 1、里氏转换一 子类赋值父类
            ////Student student = new Student();
            ////Person p = new Person();
            //Person p = new Student();  // 子类值赋值给父类变量
            //p.PersonSayHello();
            //Student s = (Student)p;    // 如果父类中装的是子类对象，那么可以将这个父类强转为子类对象。
            //s.StudentSayHello(); 
            #endregion

            #region 2、里氏转换二 父类强转子类之is用法

            //Person p = new Student();

            ///**
            // *  is的用法：判断对象是否是类的实例
            // *  返回值：true 或者是 false
            // */
            //if(p is Teacher)
            //{
            //    Console.WriteLine("p对象是Teacher类的实例对象");
            //}
            //else
            //{
            //    Console.WriteLine("p对象是Student类的实例对象");
            //}

            #endregion

            #region 3、里氏转换二 父类强转子类之is用法 as用法

            /**
             *  as用法：将对象当作该类的实例
             *  如果成功返回转换后的对象，否则返回null
             */

            Person p = new Teacher();

            Student s = p as Student;
            if (s!=null)
            {
                s.StudentSayHello();
            }
            else
            {
                Teacher t = p as Teacher;
                t.TeacherSayHello();
            }


            #endregion

        }
    }
}

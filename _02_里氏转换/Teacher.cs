using System;
using System.Collections.Generic;
using System.Text;

namespace _02_里氏转换
{
    class Teacher:Person
    {

        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}

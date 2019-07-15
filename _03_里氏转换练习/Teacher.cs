using System;
using System.Collections.Generic;
using System.Text;

namespace _03_里氏转换练习
{
    class Teacher:Person
    {

        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }

    }
}

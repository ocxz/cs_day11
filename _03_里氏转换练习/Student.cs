using System;
using System.Collections.Generic;
using System.Text;

namespace _03_里氏转换练习
{
    class Student:Person
    {

        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }

    }
}

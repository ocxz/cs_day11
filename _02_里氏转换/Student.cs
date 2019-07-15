using System;
using System.Collections.Generic;
using System.Text;

namespace _02_里氏转换
{
    class Student:Person
    {

        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _03_里氏转换练习
{
    class Beast:Person
    {
        public void BeastSayHi()
        {
            Console.WriteLine("我是野兽");
        }

    }
}

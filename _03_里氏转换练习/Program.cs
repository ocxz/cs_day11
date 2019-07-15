using System;

namespace _03_里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  创建是个对象，放入数组中，随机取出，调用相关方法
             */

            Person[] persons = new Person[6];
            persons[0] = new Beast();   // 野兽对象
            persons[1] = new HandSome();  // 帅锅对象
            persons[2] = new Looker();   // 美女对象
            persons[3] = new Student();   // 学生对象
            persons[4] = new Teacher();   // 老师对象
            persons[5] = new Person();   // 人类对象

            Random r = new Random();
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    switch (r.Next(0, 6))
                    {
                        case 0:
                            Beast b = (Beast)persons[0];
                            b.BeastSayHi();
                            break;
                        case 1:
                            HandSome h = (HandSome)persons[1];
                            h.HandSomeSayHi();
                            break;
                        case 2:
                            Looker l = (Looker)persons[2];
                            l.LookerSayHi();
                            break;
                        case 3:
                            Student s = (Student)persons[3];
                            s.StudentSayHi();
                            break;
                        case 4:
                            Teacher t = (Teacher)persons[4];
                            t.TeacherSayHi();
                            break;
                        default:
                            Person p = (Person)persons[5];
                            p.PersonSayHi();
                            break;
                    }
                }
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

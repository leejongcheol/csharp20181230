using System;
namespace ConsoleApplication7
{
    partial class Emp
    {
        public void gotoOffice()
        {
            Console.WriteLine("출근합니다.");
        }
    }
    partial class Emp
    {
        public void Work()
        {
            Console.WriteLine("일합니다.");
        }
    }
    partial class Emp
    {
        public void getoffWork()
        {
            Console.WriteLine("퇴근합니다.");
        }
    }
    class MainTest
    {
        static void Main()
        {
            Emp e = new Emp();
            e.gotoOffice();
            e.Work();
            e.getoffWork();
        }
    }
}


/*
 서로 다른 파일에 Emp 클래스를 나누어서 정의하는 경우
[Program.cs]
using System;
namespace ConsoleApplication2
{
 partial class Emp
 {
 public int id;
 public string name;
 }
 class Program
 {
 static void Main()
 {
 Emp e1 = new Emp();
 e1.id = 1; e1.name = "1 길동";
 Console.WriteLine(e1);
 Console.WriteLine(e1.ToString());
 Emp e2 = new Emp()
 {
 id = 2,
 name = "2 길동"
 };
 Console.WriteLine(e2);
 }
 }
}
[Program2.cs]
using System;
namespace ConsoleApplication2
{
partial class Emp
 {
 public override String ToString()
 {
 return "[사원]id=" + id + ",name=" + name;
 }
 }
}
*/

using System;
namespace IsAsTest {
    class Emp : Object {  }
    class Programmer : Emp {  }
    class Program  {
        static void Main(string[] args) {
            int i = 99;
            Emp p = new Programmer();

            //하위클래스 is a 상위클래스 => OK
            if (p is Emp)  Console.WriteLine("p is Emp");
            else Console.WriteLine("p is not Emp");

            // p를 Emp로 현변환하고 OK면 Emp를 리턴, 
            // 형변환 안되면 null을 리턴한다.
            Emp e = p as Emp;

            //Emp e = (Emp)p;   //p를 Emp로 형변환하는데 오류나면 종료됨
            if (e != null)
                Console.WriteLine("p가 Emp로 형변환 OK");
         }
    }
}
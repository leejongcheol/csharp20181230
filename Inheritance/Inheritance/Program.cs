/*
C#에서 상속은 콜론(:)으로 표시하며, 하나의 클래스(자식 클래스, 파생 클래스)가 다른 클래스(부
모 클래스, 기반 클래스)에서 정의된 속성과 메소드를 이어받아 그대로 사용하는 것을 의미한다.
이미 정의된 클래스를 바탕으로 필요한 기능을 추가하여 정의하는 것을 의미하며 부모 클래스의
자원을 재사용 하는 것이다.
상속의 목적은 기본적으로 코드 재사용이며 더 나아가 계층구조를 표현하기 위한 목적도 있다.
아래와 같은 클래스를 보자. 상속으로 정의되지 않아 코드의 중복이 발생한다.
  
using System;
namespace ConsoleApplication2
{

    public class Pudle
    {
        public string name;
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Jindo
    {
        public string name;
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    class DogManager   {
        static void Main()       {
            Pudle p = new Pudle(); p.name = "푸들이"; p.jitda();
            Jindo j = new Jindo(); j.name = "진도이"; j.jitda();
        }
    }
}

이를 상속기반으로 수정하면 다음과 같다. (C#에서 상속은 콜론(:)으로 표시한다.)
자식 클래스인 Pudle, Jindo는 자신이 필요한 메소드나 속성만 정의하면 된다. 그리고 Dog 클래스
의 public 멤버 name을 속성으로 변경 해보자.

*/

using System;
namespace ConsoleApplication2
{
    public class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Pudle : Dog
    {
        public void work() { Console.WriteLine(name + "가 일한다."); }
    }
    public class Jindo : Dog
    {
        public void run() { Console.WriteLine(name + "가 달린다."); }
    }
    class DogManager
    {
        static void Main()
        {
            Pudle p = new Pudle(); p.name = "푸들이"; p.jitda(); p.work();
            Jindo j = new Jindo(); j.name = "진도이"; j.jitda(); j.run();
        }
    }
}


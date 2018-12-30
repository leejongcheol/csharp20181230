#region
/*
인터페이스는 추상 클래스와 비슷한 개념으로 규격(틀)을 정하는 것인데 추상클래스가 상속 계
층 구조간에 존재하지만 인터페이스는 다분히 수평적인 개념이다.(Dog의 하위 객체인 개가 되려
면 반드시 Dog 인터페이스를 구현해야 한다.) 어떤 클래스건 Dog이라는 인터페이스를 구현하면
Dog의 하위객체가 될 수 있다는 것이다. 인터페이스 역시 객체로 생성될 수는 없다. 위 추상클래
스를 이용한 다형성 예제를 인터페이스 기반으로 재작성 해보자. C#, JAVA에서는 상속의 경우 단
일 상속만 지원하므로 주로 인터페이스를 이용하는 것이 안전하다.
*/
#endregion

using System;
namespace ConsoleApplication2
{
    interface Dog //안에 올수있는것 : 메소드, 속성, 이벤트, 인덱서,,,,, 필드(멤버) X
    {
        string name { get; set; } //속성
        void jitda(); //추상메소드
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void work() { Console.WriteLine(name + " 일한다."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~~."); }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void run() { Console.WriteLine(name + " 달린다."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~~."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle(); p.name = "푸들이"; p.jitda(); ((Pudle)p).work();
            Dog j = new Jindo(); j.name = "진도이"; j.jitda(); ((Jindo)j).run();
        }
    }
}
using System;

#region 개요
/* 추상클래스는 다른 클래스에 상속되어 어떤 형식(틀)을 지정하는 클래스이며 인스턴스로 만들 수
없다. (new 불가) 일반 클래스 앞에 abstract라는 키워드를 붙이면 추상 클래스가 되며, 추상
메소드를 하나 이상 가진 클래스 역시 추상 클래스가 되어야 한다.
위에서 만든 Dog 클래스의 jitda() 메소드를 추상 메소드로 만들고 Dog 클래스를 추상 클래스로
정의하여 다형성을 구현하면 아래와 같다. */
#endregion
using System;
namespace ConsoleApplication2
{
    public abstract class Dog // 추상 클래스, 틀, 스펙을 정의
    {
        public string Name
        {
            get; set;
        }
        public abstract void jitda(); // 추상 메소드
    }
    public class Pudle : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + " 푸들푸들~");
        }
        public void Work()
        {
            Console.WriteLine(Name + "가 일한다.");
        }
    }
    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + " 진도진도~");
        }
        public void Run()
        {
            Console.WriteLine(Name + "가 달린다.");
        }
    }
    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle(); p.Name = "푸들이"; p.jitda(); ((Pudle)p).Work();
            Dog j = new Jindo(); j.Name = "진도이"; j.jitda(); ((Jindo)j).Run();
        }
    }
}
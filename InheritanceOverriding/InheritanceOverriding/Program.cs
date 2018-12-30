using System;
#region
/* 부모 클래스의 메소드를 자식 클래스에서 다시 정의 하는 것을 메소드 재정의(Method
Overriding)라고 부르며 다형성 기반으로 코딩할 때 흔히 쓰는 방법이다.
다형성이란 상위클래스의 메소드를 재정의한 서브클래스의 메소드가 다양한 형태로 표시될 수 있
음을 의미하며 나아가 객체지향 프로그래밍의 흐름제어를 객체를 통해 처리할 수 있는 방법이기
도 하다.
부모 클래스에재정의 될 메소드에는 virtual 키워드를 사용해야 하며, 자식 클래스에 재정의 되는
메소드에서는 override 키워드를 사용해야 한다. 상위 클래스의 메소드를 자식 클래스에서 재정
의 하는 경우 가장 많이 파생된 자식 클래스의 메소드가 실행된다. 만약 그 클래스에 실행할 메
소드가 없다면 계층구조의 상위 클래스들을 탐색해서 메소드를 실행한다. */
#endregion
namespace ConsoleApplication2
{
    public class Dog
    {
        public string Name
        {
            get; set;
        }
        public virtual void jitda()
        {
            Console.WriteLine(Name + "가 짖다.");
        }
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
            Dog p = new Pudle(); p.Name = "푸들이";
            p.jitda(); //푸들푸들
            ((Pudle)p).Work();
            Dog j = new Jindo(); j.Name = "진도이";
            j.jitda(); //진도진도
            ((Jindo)j).Run();
        }
    }
}





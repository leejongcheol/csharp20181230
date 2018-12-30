using System; 
namespace OverrideAndNew
{
    class MyBaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }
    class MyDerivedClass : MyBaseClass
    {
        public override void Method1() //상위클래스 메소드 재정의
        {
            Console.WriteLine("Derived - Method1");
        }
        public new void Method2() //상위클래스의 메소드 가리기(hiding)
        {
            Console.WriteLine("Derived - Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass bc = new MyBaseClass();
            bc.Method1(); // Base - Method1
            bc.Method2(); // Base - Method2
            MyDerivedClass dc = new MyDerivedClass();
            dc.Method1(); // Derived - Method1 
             dc.Method2(); // Derived - Method2
            MyBaseClass poly = new MyDerivedClass();
            poly.Method1(); // Derived - Method1
            poly.Method2(); // Base - Method2
        }
    }
}

/*
Base - Method1
Base - Method2
Derived - Method1
Derived - Method2
Derived - Method1
Base - Method2
    */

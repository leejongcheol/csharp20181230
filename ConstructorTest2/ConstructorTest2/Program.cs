using System;
class Baseclass{
    public void func1() { Console.WriteLine("baseclass func1..."); }
    public virtual void func2() { Console.WriteLine("baseclass func2..."); }
    public virtual void func3() { Console.WriteLine("baseclass func3..."); }
}
class A : Baseclass {
    public override void func2() { Console.WriteLine("A func2..."); }
}
class Derivedclass : A {
    new public void func1() { Console.WriteLine("derivedclass func1...");  }   
    public new void func3() { Console.WriteLine("derivedclass func3...");  }
}
class Program{
    static void Main(string[] args)    {
        Baseclass b = new Derivedclass();
        b.func1();        b.func2();        b.func3();
    }
}
using System;

//델리게이트 선언
public delegate string FirstDelegate(int x);

class DelegateTest
{
    string name;

    static void Main()
    {
        //static 메소드는 델리게이트 생성시 객체참조 필요없다. 직접 접근가능
        FirstDelegate d1 = new FirstDelegate(StaticMethod);

        DelegateTest instance = new DelegateTest();
        instance.name = "My instance";
        // InstanceMethod 메소드는 static 이 아니므로 객체생성후 접근
        FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

        Console.WriteLine(d1(10)); // Writes out "Static method: 10"
        Console.WriteLine(d2(5));  // Writes out "My instance: 5"
    }

    static string StaticMethod(int i)
    {
        return string.Format("Static method: {0}", i);
    }

    string InstanceMethod(int i)
    {
        return string.Format("{0}: {1}", name, i);
    }
}
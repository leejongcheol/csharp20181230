using System;
public struct Point
{
    public int x, y;
    // 반드시 매개변수 있는 생성자를 만들어야 하며 인스턴스 필드를 꼭 초기화 해야 한다.
    //초기화 수식을 빼고 테스트 해보라...
    public Point(int x, int y)
    {
        this.x = x; this.y = y;
    }
    // Override the ToString method:
    public override string ToString()
    {
        return (String.Format("({0},{1})", x, y));
    }
}
class MainClass
{
    static void Main()
    {
        //구조체를 new 해서 생성하더라도 스택영역에 저장된다.
        //구조체는 System.ValueType을 상속받았다.
        Point p1 = new Point(); Point p2 = new Point(1, 2);
        // Display the results using the overriden ToString method:
        Console.WriteLine("기본생성자 Point : {0}", p1);
        Console.WriteLine("Point (1,2) : {0}", p2);

        Point p3; p3.x = 100; p3.y = 200;
        Console.WriteLine("Point (100,200) : {0}", p3);
    }
}
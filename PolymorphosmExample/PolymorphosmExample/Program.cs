using System;
using System.Collections.Generic;

public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public virtual void Draw() //가상 메소드, 자식클래스에서 재정의 할 수 있다.
    {
        Console.WriteLine("base class 그리기 작업");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("원을 그리다");
        base.Draw();
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("사각형을 그리다");
        base.Draw();
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("삼각형을 그리다");
        base.Draw();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle());
        shapes.Add(new Triangle());
        shapes.Add(new Circle());
        foreach (Shape s in shapes)
        {
            s.Draw();
        }
    }
}
/*
사각형을 그리다
base class 그리기 작업
삼각형을 그리다
base class 그리기 작업
원을 그리다
base class 그리기 작업
 */

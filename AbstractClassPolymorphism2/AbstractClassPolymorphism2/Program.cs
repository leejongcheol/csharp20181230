using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract void Draw();
}
class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("원을 그리다");
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("사각형을 그리다");
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("삼각형을 그리다");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Draw d = new Draw();
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
삼각형을 그리다
원을 그리다
*/

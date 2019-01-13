using System;
namespace ConsoleApplication11{
    class Program    {
        static void Main(string[] args)
        {
            Func<int, int, int> c1 = (i, j) => i + j;  //람다식, 무명함수,익명메소드            
            Console.WriteLine($"3+4={c1(3, 4)}");
        }      
    }
}
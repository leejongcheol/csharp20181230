using System;
namespace ConsoleApplication1{
    class MyConstants  {
        //상수, 값을 한번은 대입가능하지만 변경불가
        public const double PI = 3.14;   
        public const int MYAGE = 22;
    }
    class Program  {
        static void Main(string[] args)  {
            double radius = 2;
            double area = MyConstants.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age={1}", 
                                               area, 
                                               MyConstants.MYAGE);
            Console.WriteLine("Area = " + area + ", Age=" + MyConstants.MYAGE );
            //MyConstants.MYAGE = 20; //오류
            const string name = "홍길동";
            Console.WriteLine("name : " + name);
            //name = "김길동"; //오류
        }
    }
}
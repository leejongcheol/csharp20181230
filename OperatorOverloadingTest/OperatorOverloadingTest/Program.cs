using System;
namespace OperatorOverloadingTest
{
    class Adder  {
        public int Value { get; set; };  //자동구현속성

        //연산자 오버로딩( + 연산자에 대해 오버로딩)
        public static Adder operator +(Adder a1, Adder a2)   {
            Adder a3 = new Adder();
            a3.Value = a1.Value + a2.Value;
            return a3;
        }
        public override string ToString()    {   return $"[Value]={Value}";  }
    }
    class Program    {
        static void Main(string[] args)        {
            Adder a1 = new Adder(); a1.Value = 10;
            Adder a2 = new Adder(); a2.Value = 90;
            //원래객체를 + 할수는 없다. + 는 피연산자로 숫자가 와야한다.
            //Adder 클래스에  operator + 로 + 를 연산자오버로딩 했다.
            // 아래 + 실행시 Adder의 operator + 메소드가 실행된다.
            Adder a3 = a1 + a2;
            Console.WriteLine(a3);
        }
    }
}

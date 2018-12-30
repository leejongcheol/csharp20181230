using System;
namespace Test
{
    class Tester
    {
        private int m = 88, n = 99;
        //Tester(){
        // this.m = 0; this.n = 0;
        //}
        //위 기본생성자의 의미를 포함하고 있다.
        Tester(int m = 0, int n = 0)
        {
            this.m = m; this.n = n;
        }
        //선택적 매개변수
        static int Sum(int i = 0, int j = 0) // i, j 매개변수없이 호출되면 I,j에 0이 대입
        {
            return i + j;
        }
        static int Minus(int i = 0, int j = 0) // i, j 매개변수없이호출되면 0이 대입됨
        {
            return i - j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(j: 7));
            Console.WriteLine(Sum());
            Tester t1 = new Tester();
            Console.WriteLine("m={0}, n={1}", t1.m, t1.n);
            Tester t2 = new Tester(1, 2);
           Console.WriteLine("m={0}, n={1}", t2.m, t2.n);
            Console.WriteLine(Minus(1, 2)); //i=1, j=2
            Console.WriteLine(Minus(1)); //i=1, j=0
            Console.WriteLine(Minus(i: 8, j: 9)); //i=8, j=9
            Console.WriteLine(Minus(j: 8, i: 9)); //i=9, j=8
            Console.WriteLine(Minus()); //i=0, j=0
        }

    }
}
/* 결과 *3
7
0
m=0, n=0
m=1, n=2
-1
1
-1
1
0

    */
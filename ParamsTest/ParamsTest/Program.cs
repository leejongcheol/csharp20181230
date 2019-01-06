using System;
namespace ParamsTest{
    class Program    {
        static void Main(string[] args)        {
            Console.WriteLine(Sum3(j:1,i:2));  //명명된인수
            Console.WriteLine(Sum3(j:1, i:2, k:3));  //명명된인수
            Console.WriteLine(Sum());
            Console.WriteLine( Sum(1,2) );
            Console.WriteLine(new int[] { 1,2,3,4,5 });
        }
        static int Sum3(int i=0, int j=0, int k=0)  //선택적인수
        {
            Console.WriteLine("i={0}, j={1}, k={2}", i, j, k);
            return i + j + k;
        }
        static int Sum(params int[] iArr)
        {
            int sum = 0;
            foreach( int  num in  iArr   )
            {
                sum += num;
            }
            return sum;
        }
    }
}

using System;
using System.Linq;

class A
{
    static void Main()
    {
        Console.WriteLine(Enumerable.Range(1, 10000).Sum(o => o.ToString().Count(n => n == '7')));
        string a = "Hello";
        string b = "C#";
        string result = $" {a} , {b} 화이팅!";
        Console.WriteLine(result);
        Console.WriteLine($" {a} , {b} 화이팅!");
    }
}


/*

using System;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4 
            int[][] a = { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 } };
            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6) 
            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //가변배열 출력 
            foreach (int[] i in a)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine("\n---------------\n");
            //이차원 배열 출력 
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
        }
    }
} 





2. 
//12345678 
//12345678 

using System; 
using System.Collections.Generic; 
namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //----4행2열 
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach (int k in twoDim)
            {
                Console.Write(k);
            }
        }
    }
}
*/
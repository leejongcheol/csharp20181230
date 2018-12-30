using System;

namespace _019.반복문실습_과제_
{
    class Question1
    {
        // 1. 다음과 같은 결과를 출력하는 C# 프로그램을 작성하세요. 
        // 출력형태 : 2 4 6 8 10 
        // => Method Name : EvenOutput() 
        // => Field : 1씩증가할 수 - i 

        // 2. 숫자를 입력하면 다음과 같이 출력하는 C# 프로그램을 작성하세요. 
        // [출력] 
        // 입력숫자 : 10 
        // 10까지의 숫자 : 1 2 3 4 5 6 7 8 9 10 
        // 10까지의 숫자합은 : 55 
        // => Method Name : UpToNumAndSum() 
        // Field : 입력숫자 - (String inputStr, int inputNum), 누적합 - sum 

        // 3. 구구단 출력 
        // 출력을 원하는 구구단 단수를 입력받아 다음과 같이 출력결과를 만들어내는 C# 프로그램을 작성하세요. 
        // 출력을 원하는 구구단 단수 : 3 
        // 1x2 = 2, 2x2 = 4, 3x2 = 6 
        // 1x3 = 3, 2x3 = 6, 3x3 = 9 
        // 1x4 = 4, 2x4 = 8, 3x4 = 12 
        // 1x5 = 5, 2x5 = 10, 3x5 = 15 
        // 1x6 = 6, 2x6 = 12, 3x6 = 18 
        // 1x7 = 7, 2x7 = 14, 3x7 = 21 
        // 1x8 = 8, 2x8 = 16, 3x8 = 24 
        // 1x9 = 9, 2x9 = 18, 3x9 = 27 
        // => Method Name : Gugudan() 
        // Field : 기준수(1 ~ 9) - i, 사용자로 부터 입력 받을 단 - (string inputDanStr, int inputDanNum), i * inputDan - result 

        static void Main(string[] args)
        {
            // 문제1 
            EvenOutput();

            // 개행 
            Console.WriteLine();

            // 객체생성 
            Question1 solution = new Question1();

            // 문제2 
            solution.UpToNumAndSum();

            // 개행 
            Console.WriteLine();

            // 문제3 
            solution.Gugudan();

        }

        // 문제1 
        static void EvenOutput()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        // 문제2 
        public void UpToNumAndSum()
        {
            // 변수선언 
            string inputStr = null;
            int inputNum = 0;
            int sum = 0;

            Console.Write("입력숫자 : ");
            // 사용자로 부터 값입력받음. 
            inputStr = Console.ReadLine();
            // 문자열 형태의 값을 int형으로 변경. 
            inputNum = Convert.ToInt32(inputStr);

            // Title 출력 "10까지의 숫자 : " 
            Console.Write("{0}까지의 숫자 : ", inputNum);
            // 1 ~ inputNum 까지 출력하고 누적합 구하기 
            for (int i = 1; i <= inputNum; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            // 개행 
            Console.WriteLine();
            // 누적합 출력 
            Console.WriteLine("{0}까지의 숫자합은 : {1}", inputNum, sum);

        }

        // 문제3 
        public void Gugudan()
        {
            // 변수선언 
            string inputDanStr = null;
            int inputDanNum = 0;
            int result = 0;

            Console.Write("출력을 원하는 구구단 단수 : ");
            // 사용자로 부터 값입력받음. 
            inputDanStr = Console.ReadLine();
            // 문자열 형태의 값을 int형으로 변경. 
            inputDanNum = Convert.ToInt32(inputDanStr);

            // 구구단 출력 
            for (int i = 2; i <= 9; i++)  // 단 
            {
                for (int j = 1; j <= inputDanNum; j++)    // 1 ~ 9 
                {
                    // 곱셈하기 
                    result = j * i;
                    // 구구단 출력 
                    Console.Write("{0}x{1} = {2},  ", j, i, result);
                }

                // 개행 
                Console.WriteLine();
            }
        }


    }
}
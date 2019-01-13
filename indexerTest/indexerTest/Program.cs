using System;
namespace indexerTest {
    class Dept  {
        //string 배열, 인스턴스변수
        public string[] emps = new string[2];

        //인덱서정의, 이름이 this인 프로퍼티, 첨자(인덱스)가 있다.
        //객체를 배열문법처럼 접근할 수 있는 방법을 제공
        //emps 라는 배열의 값을 get, set 하기위해 인덱서 정의
        public string this[int index]     {
            get             {                return emps[index];            }
            set             {                emps[index] = value;            }
        }
    }
    class Program  {
        static void Main(string[] args)    {
            Dept d1 = new Dept();
            //인덱서를 사용안한 경우
            d1.emps[0] = "김길동"; d1.emps[0] = "홍길동";

            //인덱서를 사용한 경우
            d1[0] = "김길동";      Console.WriteLine(d1[0]);
            d1[1] = "홍길동";      Console.WriteLine(d1[1]);
        }
    }
}

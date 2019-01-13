using System;
namespace ConsoleApplication1{
    //이벤트 발생시 넘길 데이터(System.EventArgs 에서 파생)
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }

    //이벤트 게시자 클래스
    class EventPublisher    {
        //public delegate void MyEventHandler();
        //이벤트 처리를 위한 델리게이트 정의
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()
        {
               MyEvent?.Invoke(this, new EventPublisherArgs("홍길이")); //이벤트 발생                

        }
    }
    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }
        //MyEvent 이벤트가 발생하면 호출되는 메소드
        //System.EventHandler 의 기본형태가 매개변수 2 개받고,
        //리턴형이 void 형 이므로 같은 형태로 만든다.
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}
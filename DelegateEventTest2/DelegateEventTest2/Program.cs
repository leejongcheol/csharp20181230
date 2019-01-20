using System;

class Test
{
    private EventHandler MyEvent;
    public event EventHandler MyEvent
    {
        add
        {
            Console.WriteLine("add operation");
            handler += value;            
        }

        remove
        {
            Console.WriteLine("remove operation");
            handler -= value;
        }
    }
    public event EventHandler MyEvent2;

    public void Do()
    {
        handler?.Invoke(null, null); //이벤트 발생
        MyEvent2?.Invoke(null, null);
    }

    static void Main()
    {
        Test t = new Test();

        //t.MyEvent += t.DoNothing;
        t.MyEvent += new EventHandler(t.DoNothing);
        t.MyEvent2 += new EventHandler(t.DoNothing);
        t.MyEvent -= null;
        t.Do();

    }

    void DoNothing(object sender, EventArgs e)
    {
        Console.WriteLine("DoNothing Called...");
    }
}
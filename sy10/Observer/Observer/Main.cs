using System;
namespace Observer
{
    class Program
    {

        static void Main(string[] args)
        {
            //创建Subject和Observer对象
            Cat cat = new Cat();
            Mouse mouse = new Mouse();
            Master master = new Master();

            //注册观察者
            cat.Attach(mouse);
            cat.Attach(master);

            //触发事件
            cat.Yell();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> channels = new List<object>();
            channels.Add("频道1");
            channels.Add("频道2");
            channels.Add("频道3");
            channels.Add("频道4");

            AbstractChannelList list;
            AbstractIterator iterator;

            list = new ChannelList(channels);
            iterator = list.CreateIterator();

            Console.WriteLine("正向遍历：");
            while (!iterator.IsLast())
            {
                Console.WriteLine(iterator.GetNextChannel());
                iterator.Next();
            }

            Console.WriteLine("逆向遍历：");
            while (!iterator.IsFirst())
            {
                Console.WriteLine(iterator.GetPreviousChannel());
                iterator.Previous();
            }
        }
    }
}

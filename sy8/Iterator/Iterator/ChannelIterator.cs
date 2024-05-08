using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ChannelIterator:AbstractIterator
    {
        private ChannelList channelList;
        private List<object> channel;
        private int cursor1;
        private int cursor2;

        public ChannelIterator(ChannelList list)
        {
            this.channelList = list;
            this.channel=list.GetObjects();
            cursor1 = 0;
            cursor2 = channel.Count-1;
        }

        public void Next()
        {
            if(cursor1 < channel.Count)
            {
                cursor1++;
            }
        }

        public bool IsLast()
        {
            return cursor1==channel.Count;
        }

        public void Previous()
        {
            if (cursor2 > -1)
            {
                cursor2--;
            }
        }

        public bool IsFirst()
        {
            return cursor2 == -1;
        }

        public object GetNextChannel()
        {
            return channel[cursor1];
        }

        public object GetPreviousChannel()
        {
            return channel[cursor2];
        }
    }
}

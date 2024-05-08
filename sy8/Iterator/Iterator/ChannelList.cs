using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ChannelList:AbstractChannelList
    {
        public ChannelList(List<object> channel):base(channel) { }

        public override AbstractIterator CreateIterator()
        {
            return new ChannelIterator(this);
        }
    }
}

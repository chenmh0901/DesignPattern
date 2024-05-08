
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class AbstractChannelList
    {
        protected List<object> objects;
        
        public AbstractChannelList(List<object> objects)
        {
            this.objects = objects;
        }

        public void AddChannel(object channel)
        {
            objects.Add(channel);
        }

        public void RemoveChannel(object channel)
        {
            objects.Remove(channel);
        }

        public List<object> GetObjects()
        {
            return objects;
        }

        public abstract AbstractIterator CreateIterator();
    }
}

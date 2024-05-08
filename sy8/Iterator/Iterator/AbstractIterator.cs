using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface AbstractIterator
    {
        void Next();
        bool IsLast();
        void Previous();
        bool IsFirst();
        object GetNextChannel();
        object GetPreviousChannel();
    }
}

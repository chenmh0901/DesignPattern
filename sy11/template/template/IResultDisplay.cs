using System;
using System.Collections.Generic;

namespace template
{
    public interface IResultDisplay
    {
        void Display(IEnumerable<string> results);
    }
}

using System;
using System.Collections.Generic;

namespace template
{
    public interface IQueryImplementor
    {
        IEnumerable<string> Search(string query);
    }
}

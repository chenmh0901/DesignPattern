using System;
using System.Collections.Generic;

namespace template
{
    public interface IQueryImplementation
    {
        IEnumerable<string> Search(string query);
    }
}

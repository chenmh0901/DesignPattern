using System;
using System.Collections.Generic;

namespace template
{
    public class NameQuery: IQueryImplementation
    {
        public NameQuery()
        {
        }
        public IEnumerable<string> Search(string query)
        {
            // 假设这里实现了根据名称查询客户信息的逻辑
            return new List<string> { "Alice", "Bob" };
        }
    }
}

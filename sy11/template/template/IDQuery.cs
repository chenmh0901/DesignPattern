using System;
using System.Collections.Generic;

namespace template
{
    public class IDQuery :IQueryImplementor
    {
        public IEnumerable<string> Search(string query)
        {
            // 假设这里实现了根据编号查询客户信息的逻辑
            return new List<string> { "C001", "C002" };
        }
    }
}

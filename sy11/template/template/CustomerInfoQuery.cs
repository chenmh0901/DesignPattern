using System;
using System.Collections.Generic;

namespace template
{
    public abstract class CustomerInfoQuery
    {
        protected IQueryImplementation queryImpl;
        protected IResultDisplay resultDisplay;

        public CustomerInfoQuery(IQueryImplementation impl, IResultDisplay display)
        {
            queryImpl = impl;
            resultDisplay = display;
        }

        public void ExecuteQuery(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("搜索关键词无效。");
                return;
            }

            keyword = keyword.Trim();
            var results = DoQuery(keyword);
            DisplayResults(results);
        }

        protected abstract IEnumerable<string> DoQuery(string keyword);
        protected abstract void DisplayResults(IEnumerable<string> results);
    }
}

using System;
using System.Collections.Generic;

namespace template
{
    public class SpecificCustomerInfoQuery: CustomerInfoQuery
    {
        public SpecificCustomerInfoQuery(IQueryImplementation impl, IResultDisplay display)
    : base(impl, display)
        {
        }

        protected override IEnumerable<string> DoQuery(string keyword)
        {
            return queryImpl.Search(keyword);
        }

        protected override void DisplayResults(IEnumerable<string> results)
        {
            resultDisplay.Display(results);
        }
    }
}

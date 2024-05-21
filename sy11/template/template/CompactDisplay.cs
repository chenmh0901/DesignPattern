using System;
using System.Collections.Generic;

namespace template
{
    public class CompactDisplay:IResultDisplay
    {
        public void Display(IEnumerable<string> results)
        {
            // 这里实现了精简模式下显示结果的逻辑
            Console.WriteLine("显示精简模式结果：");
            Console.WriteLine(string.Join(", ", results));
        }
    }
}

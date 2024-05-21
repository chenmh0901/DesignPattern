using System;
using System.Collections.Generic;

namespace template
{
    public class FullDisplay: IResultDisplay
    {
        public void Display(IEnumerable<string> results)
        {
            // 这里实现了完整模式下显示结果的逻辑
            Console.WriteLine("显示完整模式结果：");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}

using System;
namespace template
{
    public class Program
    {
        static void Main(string[] args)
        {
              // 初始化查询和显示的方式
              var queryImpl = new NameQuery();
              var resultDisplay = new FullDisplay();

              // 创建查询对象
              var customerQuery = new SpecificCustomerInfoQuery(queryImpl, resultDisplay);

              // 执行查询
              customerQuery.ExecuteQuery("Alice");

              Console.ReadLine();
        }
    }
}

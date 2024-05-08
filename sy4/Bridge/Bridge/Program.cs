 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            FileType d=new pdf();
            pdf pdf;
            MysqlImp mysql=new MysqlImp();

            d.SetDataImp(mysql);
            d.ParseFile("pdf");
            Console.Read();
        }
    }
}

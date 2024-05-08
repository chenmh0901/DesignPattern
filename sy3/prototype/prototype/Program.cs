using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            DataChart dc1,dc2;
            dc1 = new DataChart();
            DataSet ds = new DataSet();
            ds.Name = "数据集1";
            dc1.DataSet = ds;
            dc1.No = 1;
            dc1.Color = "red";
            dc1.Data = "12";
            dc2 = dc1.Clone();
            dc2.No = 2;
            dc2.Color = "blue";
            dc2.Data = "13";
            Console.WriteLine("dc1 no {0} dc2 no {1}", dc1.No,dc2.No);
            Console.WriteLine("dc1 color {0} dc2 color {1}", dc1.Color,dc2.Color);
            Console.WriteLine("dc1 data {0} dc2 data {1}", dc1.Data,dc2.Data);
            Console.WriteLine("dc1 dataset {0} dc2 dataset {1}", dc1.DataSet.Name, dc2.DataSet.Name);
        }
    }
}

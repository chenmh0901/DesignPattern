using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer;
            ComputerController cc = new ComputerController();
            PC pc=new PC();
            computer = cc.Construct(pc);

            Console.WriteLine("类型 {0}", computer.Type);
            Console.WriteLine("CPU {0}", computer.CPU);
            Console.WriteLine("GPU {0}", computer.GPU);
            Console.WriteLine("电池 {0}", computer.Battery);
            Console.WriteLine("显示器 {0}", computer.Monitor);
            Console.WriteLine("硬盘 {0}", computer.HardDisk);
            Console.WriteLine("内存 {0}", computer.Memory);
            Console.WriteLine("风扇 {0}", computer.Fan);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class ComputerController
    {
       public Computer Construct(ComputerBuilder cb)
        {
            Computer computer;
            cb.BuildBattery();
            cb.BuildCPU();
            cb.BuildFan();
            cb.BuildGPU();
            cb.BuildHardDisk();
            cb.BuildMemory();
            cb.BuildMonitor();
            cb.BuildType();
            computer = cb.CreateComputer();
            return computer;
        }
    }
}

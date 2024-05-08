using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();

        public abstract void BuildType();
        public abstract void BuildCPU();
        public abstract void BuildMemory();
        public abstract void BuildMonitor();
        public abstract void BuildGPU();
        public abstract void BuildHardDisk();
        public abstract void BuildFan();
        public abstract void BuildBattery();

        public Computer CreateComputer()
        {
            return computer;
        }
    }
}

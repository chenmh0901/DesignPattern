using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Laptop:ComputerBuilder
    {
        public override void BuildType()
        {
            computer.Type = "Laptop";
        }
        public override void BuildCPU()
        {
            computer.CPU = "英特尔";
        }
        public override void BuildMonitor()
        {
            computer.Monitor = "AOC";
        }
        public override void BuildGPU()
        {
            computer.GPU = "NVDA";
        }
        public override void BuildHardDisk()
        {
            computer.HardDisk = "WESTDATA";
        }
        public override void BuildFan()
        {
            computer.Fan = "风扇";
        }
        public override void BuildBattery()
        {
            computer.Battery = "电池";
        }
        public override void BuildMemory()
        {
            computer.Memory = "内存条";
        }
    }
}

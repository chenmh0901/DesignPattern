using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class PC:ComputerBuilder
    {
        public override void BuildType()
        {
            computer.Type = "PC";
        }
        public override void BuildCPU()
        {
            computer.CPU = "英特尔2";
        }
        public override void BuildMonitor()
        {
            computer.Monitor = "AOC2";
        }
        public override void BuildGPU()
        {
            computer.GPU = "NVDA2";
        }
        public override void BuildHardDisk()
        {
            computer.HardDisk = "WESTDATA2";
        }
        public override void BuildFan()
        {
            computer.Fan = "风扇2";
        }
        public override void BuildBattery()
        {
            computer.Battery = "电池2";
        }
        public override void BuildMemory()
        {
            computer.Memory = "内存条2";
        }
    }
}

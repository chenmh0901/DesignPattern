using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Computer
    {
        private string type;
        private string cpu;
        private string memory;
        private string harddisk;
        private string monitor;
        private string gpu;
        private string fan;
        private string battery;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        public string Memory
        {
            get { return memory; }
            set { memory = value; }
        }
        public string HardDisk
        {
            get { return harddisk; }
            set { harddisk = value; }
        }
        public string Monitor
        {
            get { return monitor; }
            set { monitor = value; }
        }
        public string GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        public string Fan
        {
            get { return fan; }
            set { fan = value; }
        }
        public string Battery
        {
            get { return battery; }
            set { battery = value; }
        }
    }
}

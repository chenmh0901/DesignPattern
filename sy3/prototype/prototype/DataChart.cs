using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class DataChart
    {
        private DataSet dataSet;
        private string color;
        private string data;
        private int no;

        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public DataChart Clone()
        {
            return this.MemberwiseClone() as DataChart;
        }
    }
}

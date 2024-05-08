using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Coordinates
    {
        private string place;
        private string size;

        public Coordinates(string place,string size)
        {
            this.place = place;
            this.size = size;
        }

        public string Place
        {
            get { return place; }
            set { this.place = value; }
        }
        public string Size
        {
            get { return size; }
            set { this.size = value; }
        }
    }
}

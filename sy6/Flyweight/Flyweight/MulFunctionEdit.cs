using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract class MulFunctionEdit
    {
        public abstract string GetName();

        public void Display(Coordinates coord)
        {
            Console.WriteLine("这是{0},位置是{1},大小是{2}", GetName(),coord.Place,coord.Size);
        }
    }
}

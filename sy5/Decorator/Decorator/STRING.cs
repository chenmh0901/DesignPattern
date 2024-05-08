using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class STRING:Encryption
    {
        public override void Display()
        {
            Console.WriteLine("这是一个字符串");
        }
    }
}

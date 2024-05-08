using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Text:Component
    {
        private string name;
        public Text(string name)
        {
            this.name = name;
        }

        public override void Display()
        {
            Console.WriteLine("这是{0}",name);
        }
        public override void Add(Component component)
        {
            Console.WriteLine("不支持该方法");
        }
    }
}

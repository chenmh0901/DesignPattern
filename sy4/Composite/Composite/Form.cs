using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Form:Component
    {
        private string name;
        private List<Component> children = new List<Component>();

        public Form(string name)
        {
            this.name = name;
        }
        public override void Display()
        {
            Console.WriteLine("{0}显示开始",name);
            foreach (var child in children)
            {
                // 递归显示所有子控件
                child.Display();
            }
            Console.WriteLine("窗体显示结束");
        }
        public override void Add(Component component)
        {
            children.Add(component);
        }
    }
}

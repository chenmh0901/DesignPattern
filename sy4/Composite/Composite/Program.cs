using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component form1, form2, form3, c2, c3, c4;
            form1 = new Form("窗体1");
            form2 = new Form("窗体2");
            form3 = new Form("窗体3");
            c2 = new Button("按钮1");
            c3 = new Button("按钮2");
            c4 = new Text("文本框1");

            form1.Add(c2);
            form1.Add(c4);
            form2.Add(c3);

            form3.Add(form1);
            form3.Add(form2);
            form3.Display();
            Console.Read();
        }
    }
}

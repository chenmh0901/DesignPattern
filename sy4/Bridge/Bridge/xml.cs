using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class xml:FileType
    {
        public override void ParseFile(string filename)
        {
            dataImp.Transform();
            Console.WriteLine("转换为{0}格式", filename);
        }
    }
}

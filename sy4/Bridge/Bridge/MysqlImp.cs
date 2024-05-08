using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MysqlImp:FileImp
    {
        public void Transform()
        {
            Console.WriteLine("Mysql数据库");
        }
    }
}

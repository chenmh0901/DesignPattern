using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class OracleImp : FileImp
    {
        public void Transform()
        {
            Console.WriteLine("Oracle数据库");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption encryption1, encryption2, encryption3;
            encryption1 = new STRING();
            encryption2 = new EasyEncryptionDecorator(encryption1);
            encryption3 = new HardEncryptionDecorator(encryption2);
            encryption2.Display();
            encryption3.Display();
        }
    }
}

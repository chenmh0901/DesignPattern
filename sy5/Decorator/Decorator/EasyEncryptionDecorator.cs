using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EasyEncryptionDecorator:EncryptionDecorator
    {
        public EasyEncryptionDecorator(Encryption encryption):base(encryption)
        {

        }
        public override void Display()
        {
            EasyEncryption();
            base.Display();
        }
        public void EasyEncryption()
        {
            Console.WriteLine("简单移位加密");
        }
    }
}

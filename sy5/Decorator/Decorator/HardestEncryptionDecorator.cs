using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HardestEncryptionDecorator:EncryptionDecorator
    {
        public HardestEncryptionDecorator(Encryption encryption) : base(encryption)
        {

        }
        public override void Display()
        {
            EasyEncryption();
            base.Display();
        }
        public void EasyEncryption()
        {
            Console.WriteLine("求模加密");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HardEncryptionDecorator : EncryptionDecorator
    {
        public HardEncryptionDecorator(Encryption encryption) : base(encryption)
        {

        }
        public override void Display()
        {
            EasyEncryption();
            base.Display();
        }
        public void EasyEncryption()
        {
            Console.WriteLine("稍微复杂逆向输出加密");
        }
    }
}

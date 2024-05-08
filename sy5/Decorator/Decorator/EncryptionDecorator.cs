using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EncryptionDecorator:Encryption
    {
        private Encryption encryption;
        public EncryptionDecorator(Encryption encryption)
        {
            this.encryption = encryption;
        }

        public override void Display()
        {
            encryption.Display();
        }
    }
}

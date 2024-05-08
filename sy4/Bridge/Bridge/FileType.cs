using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class FileType
    {
        protected FileImp dataImp;

        public void SetDataImp(FileImp dataImp)
        {
            this.dataImp = dataImp;
        }

        public abstract void ParseFile(string filename);
    }
}

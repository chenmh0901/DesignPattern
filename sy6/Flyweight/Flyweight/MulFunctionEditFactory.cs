using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class MulFunctionEditFactory
    {
        private static MulFunctionEditFactory instance = new MulFunctionEditFactory();
        private Hashtable hashtable;

        private MulFunctionEditFactory()
        {
            hashtable = new Hashtable();
            MulFunctionEdit image, vedio, animation;
            image = new Image();
            vedio = new Vedio();
            animation = new Animation();
            hashtable.Add("image", image);
            hashtable.Add("vedio", vedio);
            hashtable.Add("animation", animation);
        }

        public static MulFunctionEditFactory GetInstance()
        {
            return instance;
        }
        public MulFunctionEdit GetFunctionEdit(string name)
        {
            return (MulFunctionEdit)hashtable[name];
        }
    }
}

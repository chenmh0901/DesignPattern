using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            MulFunctionEdit image1, image2, image3, vedio, animation;
            MulFunctionEditFactory mulFunctionEditFactory;

            mulFunctionEditFactory = MulFunctionEditFactory.GetInstance();

            image1 = mulFunctionEditFactory.GetFunctionEdit("image");
            image2 = mulFunctionEditFactory.GetFunctionEdit("image");
            image3 = mulFunctionEditFactory.GetFunctionEdit("image");
            vedio = mulFunctionEditFactory.GetFunctionEdit("vedio");
            animation = mulFunctionEditFactory.GetFunctionEdit("animation");
            image1.Display(new Coordinates("1,2", "2"));
            image2.Display(new Coordinates("2,2", "1"));
            image3.Display(new Coordinates("3,2", "3"));
            vedio.Display(new Coordinates("0,1", "4"));
            animation.Display(new Coordinates("2,1", "6"));
        }
    }
}

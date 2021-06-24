using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle:Circle,IDraw3D
    {
        //new keyword to hide the base property 'PetName' a bove me
        //public new string  PetName { get; set; }

        // use the keyword new to hide any Draw() implementation
        //above me
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }
        //custom constructor
        public ThreeDCircle(string name)
            :base(name)
        {
            PetName = name;
        }
        //IDraw3D  implementation
        public void Draw3D()
        {
            Console.WriteLine("Drawing 3D Circle");
        }
    }
}

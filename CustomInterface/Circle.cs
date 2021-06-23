using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //if we did not implement the abstract  Draw() then circle 

    //will be considered abstract,and would to be marked abstract!
    class Circle :Shape
    {
        public Circle()
        {

        }
        public Circle(string name)
            :base(name)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the circle",PetName);
        }
    }
}

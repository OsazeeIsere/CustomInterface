using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Interface");
            Hexagon hex = new Hexagon("Hexagon");
            Console.WriteLine("{0} Has {1} points",hex.PetName, hex.Points);

            Shape[] myShapes = new Shape[5];
            myShapes[0] = new Hexagon();
            myShapes[1] = new Circle();
            myShapes[2] = new Triangle("Angle");
            myShapes[3] = new ThreeDCircle("3D");
            myShapes[4] = new Hexagon("Hexo");
            foreach (Shape item in myShapes)
            {
                item.Draw();
                IPointy ob = item as IPointy;
                if (ob != null) { 
                Console.WriteLine("{0} has {1} points",item.PetName, ob.Points);
                }
                else
                {
                    Console.WriteLine("{0} has no points", item.PetName);

                }

                Console.WriteLine("Rendering in 3D");
                for(int i = 0; i < myShapes.Length; i++)
                {
                    if (myShapes[i] is IDraw3D)
                    {
                        Render3D((IDraw3D)myShapes[i]);
                    }
                    else
                    {
                        Console.WriteLine("No 3D copy of the shape");
                    }
                }
            }
            //interface as return value
            Console.WriteLine("interface as return value");
            foreach(Shape shapes in myShapes)
            { 
              IPointy theIPointy = NewShape(shapes);
                if (theIPointy != null)
                { 
                  Console.WriteLine("The item has {0} points",theIPointy.Points);
                }
                else
                {
                    Console.WriteLine("The item has no point");

                }
            }
            //Array of interface
            Console.WriteLine("Looking at array of interface");
            IPointy[] myPointsObjects = { new Hexagon(),new Triangle()
                    ,new Knife(),new Fork(),new PitchFork() };
            foreach(IPointy pt in myPointsObjects)
            {
                Console.WriteLine("Objects gas {0} points",pt.Points);
            }
            Console.ReadLine();

        }
        static void Render3D(IDraw3D draw3D )
        {
            if(draw3D is Hexagon)
            {
                Hexagon hex = new Hexagon();
                hex.Draw3D();

            }
            else
            {
                ThreeDCircle c = new ThreeDCircle("Great!3D");
                c.Draw3D();
            }
        }
      public static IPointy NewShape(Shape shape)
        {
            
                if (shape is IPointy && shape is Hexagon p)
                    return p;
                else if (shape is IPointy && shape is Triangle t)
                    return t;
                else
                    return null;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
   abstract class Shape
    {
        //field data
        public string PetName { get; set; }

        //custom constructor with optional parameter
        public Shape(string name="NoName")
        {
            PetName = name;
        }

        //a single virtual method turned to abstract
        //b/cos you want to force each child class to override it
        public abstract void Draw();//replace virtual with abstract
        //{
        //    Console.WriteLine("Insid Shape.Draw()");
        //}
    }
}

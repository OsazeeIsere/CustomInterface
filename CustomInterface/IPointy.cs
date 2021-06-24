using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{   // The pointy behaviour as read-only property
    interface IPointy
    {
        // A read-write property in an interface would look like this
        // retType PropName{get;set;}
        //
        //while a write-only property in an interface would look like this
        //retType PropName{set;}

            byte Points { get; }
        //Implicitly public and abstract 
        //byte GetNumberOfPoint();

    }
}

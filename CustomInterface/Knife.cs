using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
   public class Knife : IPointy
    {
        //Ipointy implementation
        public byte Points
        {
            get { return 6; }
        }

    }
}

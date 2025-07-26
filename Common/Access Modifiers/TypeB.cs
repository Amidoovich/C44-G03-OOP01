using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access_Modifiers
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            //typeA.X = 1;
            typeA.Y = 1;
            typeA.Z = 1;
          
        }
        
        
    }
}

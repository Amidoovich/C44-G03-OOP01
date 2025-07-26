using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access_Modifiers
{
    public class TypeA
    {
        private int X; 
        internal int Y;
        public int Z;

        public TypeA()
        {

        }
        public void Print()
        {
            X = 10;  // Accessable withen its Scope only
       
            Y = 20;  // Accessable withen its Scope and in class in internal Project

            Z = 30;  // Accessable withen its Scope and in class in internal Project and in class in external project
        }

    }
}

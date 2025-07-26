using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.User_Defiend_Data_Types
{
    internal interface IMyInterface
    {
         int Id { get; set; }

         void Print();

        private void MyFun()
        {
            Console.WriteLine("Hello");
        }

    }
}

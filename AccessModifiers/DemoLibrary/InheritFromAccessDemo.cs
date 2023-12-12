using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    internal class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {   
            // Access to protected modifier 
            ProtectedDemo();

            PrivateProtectedDemo();

            ProtectedInternalDemo();
            
        }
    }
}

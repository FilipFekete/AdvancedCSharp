using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class InheritanceDemo : AccessDemo
    {
        private void Demo()
        {   
            ProtectedDemo();    
            ProtectedInternalDemo();
        }
    }
}

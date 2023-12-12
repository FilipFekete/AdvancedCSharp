using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {   
        private void Demo()
        {
            PrivateDemo();
        }

        // Private - Only accesible within the class
        private void PrivateDemo()
        {
            
        }
        // Within the class that declared the method and the class that inherits from it, only in the same assembly
        private protected void PrivateProtectedDemo()
        {

        }

        // Protected - Accesible within the class or derived class
        // Almost like private, but derived classes have access as well
        protected void ProtectedDemo()
        {

        }

        // ProtectedInternal - Within the same assbemly and different assemblies if derived
        // Protected inside its own assembly, internal in dervied classes in different assemblies 
        protected internal void ProtectedInternalDemo()
        {

        }

        // Internal - Accessible within the assembly(project)
        internal void InternalDemo()
        {

        }

        // Public - Accessible everywhere 
        public void PublicDemo()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsTechnician { get; set; } = false;
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
        
    }
}

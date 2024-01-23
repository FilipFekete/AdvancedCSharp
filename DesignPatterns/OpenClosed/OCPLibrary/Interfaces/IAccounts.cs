using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Interfaces
{
    public interface IAccounts
    {
        PersonModel Create(IApplicantModel person);
    }
}

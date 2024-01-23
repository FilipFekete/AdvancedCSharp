using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class EmployeeAccounts : BaseAccounts
    {
        protected override void SetAdditionalProperties(PersonModel output, IApplicantModel person)
        {
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

        }
    }
}

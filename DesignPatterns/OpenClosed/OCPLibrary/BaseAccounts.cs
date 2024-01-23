using OCPLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public abstract class BaseAccounts : IAccounts
    {
        public PersonModel Create(IApplicantModel person)
        {
            PersonModel output = new PersonModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            //output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";

            SetAdditionalProperties(output, person);

            return output;
        }

        /// <summary>
        ///  SetAdditionalPropoerties is marked abstract, it must be given a body when overriden
        /// </summary>
        /// <param name="output"></param>
        /// <param name="person"></param>
        protected abstract void SetAdditionalProperties(PersonModel output, IApplicantModel person);
    }
}

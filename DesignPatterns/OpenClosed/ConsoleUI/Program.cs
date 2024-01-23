using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new EmployeeModel { FirstName = "Tim", LastName = "Corey" },
                new TechnicianModel {FirstName = "John", LastName = "Doe"},
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<PersonModel> employees = new List<PersonModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                string completeOccupation = $"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}";

                if (emp.IsExecutive == true)
                {
                    completeOccupation += " : Position -> Executive";   
                }
                else if (emp.IsTechnician == true) 
                { 
                    completeOccupation += " : Position -> Technician";
                }
                else if (emp.IsManager == true) 
                {
                    completeOccupation += " : Position -> Manager";
                }
                else
                {
                    completeOccupation += " : Position -> Employee";
                }

                Console.WriteLine(completeOccupation);
            }

            Console.ReadLine();
        }
    }
}

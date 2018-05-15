using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    abstract class Employee
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

        public abstract void Hire();

        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string  EmpNumber { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string Address { get; set; }
    }   
}

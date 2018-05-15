using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Manager : Employee
    {
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }

        private string department;

        public string Department { get => department; set => department = value; }
    }
}

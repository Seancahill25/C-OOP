using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();

            #region Anon Class

            var anon = new { Name = "Sean", Age = 26 };

            Console.WriteLine(anon.Name + anon.Age);

            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class UProgram
    {
        public string Uprogram { get; set; }
        public Degree Degree = new Degree("Bachelor");
    
        public UProgram(string uprogram)
        {
            this.Uprogram = uprogram;
        }
        int studentCount = Student.StudentCount();
        public void Display()
        {
            Console.WriteLine($"The Program {Uprogram} contains a {Degree.DegreeName} Degree.");
            Console.WriteLine($"You take the {Degree.Course.CourseName} to get your {Degree.DegreeName} Degree.");
            Console.WriteLine($"There are {studentCount} Students in the {Degree.Course.CourseName} Course");
        }

    }
}

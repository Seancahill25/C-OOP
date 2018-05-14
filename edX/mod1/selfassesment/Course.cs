using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class Course
    {
        public string CourseName { get; set; }
        public Student Student1 = new Student("Chuck", "Key");
        public Student Student2 = new Student("Pat", "Rick");
        public Student Student3 = new Student("Cliff", "Ford");
        public Teacher Teacher = new Teacher("Doctor", "Professer");

        public Course(string course)
        {
            this.CourseName = course;
        }
    }
}

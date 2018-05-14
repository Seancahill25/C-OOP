using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }

        public Student(string first, string last)
        {
            this.First = first;
            this.Last = last;
            Students++;
        }
        private static int Students = 0;

        

        public static int StudentCount()
        {
            return Students;
        }

    }
}

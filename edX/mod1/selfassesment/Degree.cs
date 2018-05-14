using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class Degree
    {
        public string  DegreeName { get; set; }
        public Course Course = new Course("Programming with C#");

        public Degree(string degree)
        {
            this.DegreeName = degree;
        }
    }
}

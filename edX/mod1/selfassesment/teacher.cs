using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class Teacher
    {
        public string Title { get; set; }
        public string Last { get; set; }

        public Teacher(string title, string last)
        {
            this.Title = title;
            this.Last = last;
        }
    }
}

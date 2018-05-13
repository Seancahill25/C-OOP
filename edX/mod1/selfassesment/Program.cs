using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var UProgram = new UProgram("Information Technology", "Bachelors");

            Console.WriteLine($"the Program is {UProgram.Class} and the degree it contains is {UProgram.Degree}");
        }
            
    }
    public class UProgram
    {
        public string Class { get; set; }
        public string Degree { get; set; }
   
        public UProgram(string uclass, string degree)
        {
            this.Class = uclass;
            this.Degree = degree;
        }
    }
}
